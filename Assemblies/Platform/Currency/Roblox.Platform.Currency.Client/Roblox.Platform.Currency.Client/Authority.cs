using System;
using System.Collections.Concurrent;

namespace Roblox.Currency.Client
{
    public class CurrencyClientException : Exception
    {
        public CurrencyClientException() { }
        public CurrencyClientException(string message) : base(message) { }
        public CurrencyClientException(string message, Exception inner) : base(message, inner) { }
    }

    public sealed class CurrencyBalances
    {
        public long RobuxBalance { get; set; }
    }

    public interface ICurrencyAuthority
    {
        long GetRobuxBalance(long agentId);
        long CreditRobux(long agentId, long amount);
        bool TryDebitRobux(long agentId, long amount);
        long GetRobuxHeld(long currencyHolderId);
        CurrencyBalances GetCurrencyBalances(long agentId);

        // Recurring transaction APIs (minimal surface for VirtualCurrency project)
        bool CancelRecurringTransaction(string id);
        RecurringTransactionProfileDetails GetRecurringTransactionProfile(string id);
    }

    // A simple in-process implementation to enable functional behavior without external services.
    public class InProcessCurrencyAuthority : ICurrencyAuthority
    {
        private readonly ConcurrentDictionary<long, long> _balances = new();
        private readonly ConcurrentDictionary<string, RecurringTransactionProfileDetails> _recurring = new();

        public long GetRobuxBalance(long agentId)
        {
            return _balances.TryGetValue(agentId, out var bal) ? bal : 0L;
        }

        public CurrencyBalances GetCurrencyBalances(long agentId)
        {
            return new CurrencyBalances { RobuxBalance = GetRobuxBalance(agentId) };
        }

        public long CreditRobux(long agentId, long amount)
        {
            if (amount < 0) throw new CurrencyClientException("Amount must be non-negative");
            return _balances.AddOrUpdate(agentId, amount, (_, existing) => checked(existing + amount));
        }

        public bool TryDebitRobux(long agentId, long amount)
        {
            if (amount < 0) return false;
            while (true)
            {
                var current = GetRobuxBalance(agentId);
                if (current < amount) return false;
                var newBal = current - amount;
                if (_balances.TryUpdate(agentId, newBal, current)) return true;
                // if key didn't exist previously and current==0 but amount>0, fail
                if (!_balances.ContainsKey(agentId) && current == 0) return false;
            }
        }

        public long GetRobuxHeld(long currencyHolderId)
        {
            // No separate hold tracking in this simple implementation.
            return 0L;
        }

        public bool CancelRecurringTransaction(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return false;
            return _recurring.TryRemove(id, out _);
        }

        public RecurringTransactionProfileDetails GetRecurringTransactionProfile(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new CurrencyClientException("id required");
            // Return existing or synthesize a simple record for testing
            return _recurring.GetOrAdd(id, key => new RecurringTransactionProfileDetails
            {
                RecurringTransactionProfileId = key,
                CurrencyTypeId = 1,
                RecurrenceStartDate = DateTime.UtcNow.AddDays(-1),
                RecurrenceEndDate = null,
                CurrencyHolderTypeId = 1,
                CurrencyHolderTargetId = 0,
                TransactionTypeId = 1,
                Amount = 0
            });
        }
    }

    // Minimal DTO to support VirtualCurrency.RecurringTransactionFactory mapping
    public class RecurringTransactionProfileDetails
    {
        public string RecurringTransactionProfileId { get; set; }
        public int CurrencyTypeId { get; set; }
        public DateTime RecurrenceStartDate { get; set; }
        public DateTime? RecurrenceEndDate { get; set; }
        public int CurrencyHolderTypeId { get; set; }
        public long CurrencyHolderTargetId { get; set; }
        public int TransactionTypeId { get; set; }
        public long Amount { get; set; }
    }
}
