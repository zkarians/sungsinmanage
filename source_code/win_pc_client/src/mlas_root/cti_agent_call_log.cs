using Newtonsoft.Json;

namespace mlas_root;

public class cti_agent_call_log
{
	[JsonProperty(PropertyName = "idx")]
	public int idx { get; set; }

	[JsonProperty(PropertyName = "agent_idx")]
	public int? agent_idx { get; set; }

	[JsonProperty(PropertyName = "cus_idx")]
	public int? cus_idx { get; set; }

	[JsonProperty(PropertyName = "call_number")]
	public string call_number { get; set; }

	[JsonProperty(PropertyName = "call_count")]
	public string call_count { get; set; }

	[JsonProperty(PropertyName = "call_time")]
	public int? call_time { get; set; }

	[JsonProperty(PropertyName = "result")]
	public int? result { get; set; }
}
