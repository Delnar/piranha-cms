using Piranha.AttributeBuilder;
using Piranha.Models;

namespace piranah.Models;

[PageType(Title = "Standard page")]
[ContentTypeRoute(Title = "Default", Route = "/Page")]
public class StandardPage  : Page<StandardPage>
{
}
