using System.Threading.Tasks;
using Fido2NetLib;
using Xunit;

namespace Test
{
    public class MetadataServiceTests
    {

        [Fact]
        public async Task ConformanceTestClient()
        {
            var client = new ConformanceMetadataRepository(null, "http://localhost");

            var toc = await client.GetToc();

            Assert.True(toc.Entries.Length > 0);

            var entry_1 = await client.GetMetadataStatement(toc, toc.Entries[toc.Entries.Length - 1]);

            Assert.NotNull(entry_1.Description);

        }
    }
}
