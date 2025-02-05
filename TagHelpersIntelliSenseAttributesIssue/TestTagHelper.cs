using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpersIntelliSenseAttributesIssue;

[HtmlTargetElement("test", Attributes = "test")]
public class TestTagHelper : TagHelper
{
    [HtmlAttributeName("test")]
    public bool MyProperty { get; set; }
}

[HtmlTargetElement("test2", Attributes = "test2", ParentTag = "div")]
public class TestTagHelper2 : TagHelper
{
    [HtmlAttributeName("test2")]
    public bool MyProperty { get; set; }
}