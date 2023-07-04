
using InfoWeb.Models;
using InfoWeb.Services;
using Microsoft.AspNetCore.Mvc;



[ApiController]
[Route("[controller]")]
public class FormaPagController : ControllerBase
{
    public FormaPagController()
    {
    }

    [HttpGet]
    public ActionResult<List<FormaPag>> GetFormaPags()
    {
        return FormaPagService.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<FormaPag> GetFormaPag(int id)
    {
        var FormaPag = FormaPagService.Get(id);

        if (FormaPag == null)
        {
            return NotFound();
        }

        return Ok(FormaPag);

    }

    [HttpPost]
    public IActionResult InsertFormaPag(FormaPag FormaPag)
    {
        FormaPagService.Add(FormaPag);
        return CreatedAtAction(nameof(GetFormaPag), new { FormaPag.fpg_codigo }, FormaPag); // RETORNA A URL DE ACESSO AOS DADOS DA FormaPag RECÉM CRIADA + A FormaPag RECÉM CRIADA (PADRAO)

    }

    [HttpPut("{id}")]
    public IActionResult UpdateFormaPag(int id, FormaPag FormaPag)
    {
        if (id == 0 || id != FormaPag.fpg_codigo)
        {
            return BadRequest();
        }
        var FormaPagEncontrada = FormaPagService.Get(id);
        if (FormaPagEncontrada is null)
        {
            return NotFound();
        }

        FormaPagService.Update(FormaPag);

        return NoContent(); // STATUS 204 SEM RETORNAR NADA
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteFormaPag(int id)
    {
        var FormaPagEncontrada = FormaPagService.Get(id);
        if (FormaPagEncontrada is null)
        {
            return NotFound();
        }

        FormaPagService.Delete(id);
        return NoContent();

    }
}