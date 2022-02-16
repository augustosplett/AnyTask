using Microsoft.AspNetCore.Mvc;
using AnyTask.API.Models;
using AnyTask.API.Services;

namespace AnyTask.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteItemController : ControllerBase
    {
        public NoteItemController()
        {

        }

        [HttpGet]
        public ActionResult<List<NoteItem>> GetAll() => NoteItemService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<NoteItem> Get(int id)
        {
            var noteItem  = NoteItemService.Get(id);
            if (noteItem == null)
            {
                return NotFound();
            }
            return noteItem;
        }

        [HttpPost]
        public IActionResult Create(NoteItem noteItem)
        {
            NoteItemService.Add(noteItem);
            return CreatedAtAction(nameof(Create), new { id = noteItem.Id }, noteItem);
        }
    }
}
