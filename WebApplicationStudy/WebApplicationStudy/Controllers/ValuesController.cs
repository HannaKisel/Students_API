using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationStudy.Controllers
{
  [Route("api/[controller]")]
  public class ValuesController : ControllerBase
  {
    // GET: api/<controller>
    [HttpGet]
    [Produces("application/json") ]//its a rule, that allow us to get only json format
    public IEnumerable<string> Get()
    {
      return new string[] { $"value1", "value2" };//students.getAllItem-студен сервис берет коллекцию студентов, вычитывая из некого репозитория
    }

    // GET api/value/5
    [HttpGet("{id}")]
    public IActionResult Get( int id, int query)
    {
      return Ok(new Value { Id = id, Text = "value" + id });
    }

    // POST api/values
    [HttpPost]
    public IActionResult Post([FromBody]Value value)//Value student)//+
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
        //throw new InvalidOperationException("Invalid");
      }
      //if the post successful request, save student to BD
      return CreatedAtAction("Get", new { id = value.Id }, value);
    }

    // PUT api/<controller>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string student)
    {
    }

    // DELETE api/<controller>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }

  public class Value
  {
    public int Id { get; set; }

    //[MinLength(3)]//добавим требования для длины текста, если не выполнятся, то получим ошибку прописанную выше
    public string Text { get; set; }
  }
}
