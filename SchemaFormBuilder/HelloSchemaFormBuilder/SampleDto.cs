using Fancy.SchemaFormBuilder.Annotations;

namespace Fancy.Samples.HelloSchemaFormBuilder
{
    /// <summary>
    /// Sample dto used in this sample.
    /// </summary>
    public class SampleDto
    {
        /// <summary>
        /// Example for an int property.
        /// </summary>
        [FormTitle("Int Property")]
        public int IntProperty { get; set; }

        /// <summary>
        /// Example for a string property.
        /// </summary>
        [FormTitle("String Property")]
        public string StringProperty { get; set; }
    }
}
