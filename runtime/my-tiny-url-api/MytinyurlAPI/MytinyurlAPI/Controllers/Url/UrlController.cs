using MytinyurlAPI.Data;
using MytinyurlAPI.Models;
using MytinyurlAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MytinyurlAPI.Controllers.Url
{
    [RoutePrefix("api/Url")]
    public class UrlController : ApiController
    {
        // GET: api/url/5
        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult GetUrl(string id)
        {
            try
            {                
                string s = "";

                try { if (MockBD.URLS.TryGetValue(id, out s)) { return Ok(s); } } catch { }

                return NotFound();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/url
        [Route("")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] UrlDTO c)
        {
            try
            {
                //TODO: validate url

                if (!c.url.Contains("http")) c.url = "http://" + c.url;

                c.tinyurl = new GenerateStringService().getString();

                //TODO: check if url already inserted

                //put in cache
                try { MockBD.URLS.TryAdd(c.tinyurl, c.url); } catch { }

                return Created(Url.Link("DefaultApi", new { controller = "Url", id = c.tinyurl }), c);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}