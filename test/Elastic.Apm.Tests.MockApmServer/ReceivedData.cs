using System.Collections.Immutable;

namespace Elastic.Apm.Tests.MockApmServer
{
	public class ReceivedData
	{
		internal ImmutableList<ErrorDto> Errors = ImmutableList<ErrorDto>.Empty;
		internal ImmutableList<string> InvalidPayloadErrors = ImmutableList<string>.Empty;
		internal ImmutableList<MetadataDto> Metadata = ImmutableList<MetadataDto>.Empty;
		internal ImmutableList<MetricSetDto> Metrics = ImmutableList<MetricSetDto>.Empty;
		internal ImmutableList<SpanDto> Spans = ImmutableList<SpanDto>.Empty;
		internal ImmutableList<TransactionDto> Transactions = ImmutableList<TransactionDto>.Empty;

		internal void Clear()
		{
			Errors = ImmutableList<ErrorDto>.Empty;
			InvalidPayloadErrors = ImmutableList<string>.Empty;
			Metadata = ImmutableList<MetadataDto>.Empty;
			Metrics = ImmutableList<MetricSetDto>.Empty;
			Spans = ImmutableList<SpanDto>.Empty;
			Transactions = ImmutableList<TransactionDto>.Empty;
		}
	}
}
