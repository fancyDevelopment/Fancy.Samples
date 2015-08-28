using Fancy.SchemaFormBuilder.Services;
using Microsoft.AspNet.Mvc;

namespace Fancy.Samples.HelloSchemaFormBuilder
{
    public class FormController : Controller
    {
        /// <summary>
        /// Gets the metadata of the sample dto required to render a form.
        /// </summary>
        /// <returns>An object containing the metadata required to render the form.</returns>
        [HttpGet]
        [Route("api/[controller]/Form")]
        public SchemaFormInfo GetSampleForm()
        {
            ISchemaFormBuilder schemaFormBuilder = new DefaultSchemaFormBuilder();
            return schemaFormBuilder.CreateSchemaForm(typeof(SampleDto));
        }

        /// <summary>
        /// Method to be called by the client to post an instance of a sample dto to the server. 
        /// </summary>
        /// <param name="sampleDto">An intstance of a sample dto.</param>
        /// <returns>The sample dto as json.</returns>
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult PostSampleForm([FromBody] SampleDto sampleDto)
        {
            return Json(sampleDto);
        }
    }
}
