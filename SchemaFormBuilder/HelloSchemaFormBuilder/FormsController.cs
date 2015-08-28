using Fancy.SchemaFormBuilder.Services;
using Microsoft.AspNet.Mvc;

namespace Fancy.Samples.HelloSchemaFormBuilder
{
    public class SampleController : Controller
    {
        [HttpGet]
        [Route("api/[controller]/Form")]
        public SchemaFormInfo GetSampleForm()
        {
            ISchemaFormBuilder schemaFormBuilder = new DefaultSchemaFormBuilder();
            return schemaFormBuilder.CreateSchemaForm(typeof(SampleDto));
        }

        [HttpPut]
        [Route("api/[controller]")]
        public IActionResult PutSampleForm([FromBody] SampleDto sampleDto)
        {
            return Json(sampleDto);
        }
    }
}
