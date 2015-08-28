using Fancy.SchemaFormBuilder.Annotations;

namespace Fancy.Samples.HelloSchemaFormBuilder
{
    public class SampleDto
    {
        [FormTitle("Int Property")]
        public int IntProperty { get; set; }

        [FormTitle("String Property")]
        public string StringProperty { get; set; }
    }
}
