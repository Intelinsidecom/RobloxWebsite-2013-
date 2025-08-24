namespace BeIT.MemCached;

public class Stat
{
	public string Name;

	public long uptime;

	public string version;

	public long pointer_size;

	public long curr_connections;

	public long total_connections;

	public long connection_structures;

	public long cmd_get;

	public long cmd_set;

	public long cmd_flush;

	public long get_hits;

	public long get_misses;

	public long delete_misses;

	public long delete_hits;

	public long incr_misses;

	public long incr_hits;

	public long decr_misses;

	public long decr_hits;

	public long cas_misses;

	public long cas_hits;

	public long cas_badval;

	public long auth_cmds;

	public long auth_errors;

	public long bytes_read;

	public long bytes_written;

	public long limit_maxbytes;

	public long accepting_conns;

	public long listen_disabled_num;

	public long threads;

	public long conn_yields;

	public long bytes;

	public long curr_items;

	public long total_items;

	public long evictions;
}
