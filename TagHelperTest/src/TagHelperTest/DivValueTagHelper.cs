using Microsoft.AspNet.Razor.Runtime.TagHelpers;

namespace TagHelperTest
{
    [TargetElement("div", Attributes = "sp-value")]
    public class DivValueTagHelper : TagHelper
    {
        [HtmlAttributeName("sp-value")]
        public string Value { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!string.IsNullOrWhiteSpace(Value))
            {
                output.Content.SetContent(Value);
            }
        }
    }
}