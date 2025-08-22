using System;
using System.Collections.Generic;

namespace Roblox.Avatar.Client
{
    // Minimal stubs to satisfy compile-time references
    public interface IAvatarClient
    {
        AccoutrementResult CreateAccoutrement(long userId, long userAssetId);
        void DeleteAccoutrement(long accoutrementId);
        AccoutrementResultBatch GetAccoutrementsByUserAssetIds(IEnumerable<long> userAssetIds);
        AccoutrementResultListBatch GetAccoutrementsByUserIds(IEnumerable<long> userIds);
    }

    public class ServiceOperationErrorException : Exception
    {
        public int Code { get; }
        public ServiceOperationErrorException(int code, string message) : base(message)
        {
            Code = code;
        }
    }

    public class AvatarServiceException : Exception
    {
        public int Code { get; }
        public AvatarServiceException(int code, Exception inner) : base(inner?.Message, inner)
        {
            Code = code;
        }
    }

    public enum AccoutrementError
    {
        Duplicate = 1
    }

    public class AccoutrementResult
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long UserAssetId { get; set; }
    }

    public class AccoutrementResultBatch
    {
        public IDictionary<long, AccoutrementResult> Data { get; set; }
    }

    public class AccoutrementResultListBatch
    {
        public IDictionary<long, IReadOnlyCollection<AccoutrementResult>> Data { get; set; }
    }
}
