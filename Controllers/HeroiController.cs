using System.Threading.Tasks;
using EFCore.WebApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.WebApi.Controllers
{
  public class HeroiController : Controller
  {

    private HeroiContext _context;

    public HeroiController(HeroiContext context)
    {
        _context=context;
    }

    [HttpGet("/tests")]
    public IActionResult Test()
    {
      return Ok("Sucess API");
    }

    // [HttpPost]
    // public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
    // {
    //     _context.TodoItems.Add(todoItem);
    //     await _context.SaveChangesAsync();

    //     //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
    //     return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
    // }
  }
}
