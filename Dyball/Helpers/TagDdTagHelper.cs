using Humanizer;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Dyball.Helpers
{
    [HtmlTargetElement("tag-dd")]
    public class TagDdTagHelper : TagHelper
    {
        /// <summary>
        /// Name of data property 
        /// </summary>
        [HtmlAttributeName("for")]
        public ModelExpression For { get; set; }

        [HtmlAttributeName("pipe")]
        public string Pipe { get; set; } = null;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var pipe = string.IsNullOrEmpty(Pipe) ? string.Empty : Pipe;

            var labelTag = new TagBuilder("label");
            labelTag.InnerHtml.Append(For.Metadata.Description);
            labelTag.AddCssClass("control-label");

            var pTag = new TagBuilder("p");
            pTag.AddCssClass("form-control-static");

            var dataBindExpression = ((DefaultModelMetadata)For.Metadata).DataTypeName == "Password"
                                    ? "******"
                                    : "{{" + For.CamelizedName() + pipe + "}}";

            pTag.InnerHtml.Append(dataBindExpression);

            output.TagName = "div";
            output.Attributes.Add("class", "form-group");

            output.Content.AppendHtml(labelTag);
            output.Content.AppendHtml(pTag);
        }

        
    }
}