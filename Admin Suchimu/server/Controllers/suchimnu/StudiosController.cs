using System;
using System.Net;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNet.OData.Query;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;




namespace Admin.Controllers.Suchimnu
{
  using Models;
  using Data;
  using Models.Suchimnu;

  [ODataRoutePrefix("odata/suchimnu/Studios")]
  [Route("mvc/odata/suchimnu/Studios")]
  public partial class StudiosController : ODataController
  {
    private Data.SuchimnuContext context;

    public StudiosController(Data.SuchimnuContext context)
    {
      this.context = context;
    }
    // GET /odata/Suchimnu/Studios
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Suchimnu.Studio> GetStudios()
    {
      var items = this.context.Studios.AsQueryable<Models.Suchimnu.Studio>();
      this.OnStudiosRead(ref items);

      return items;
    }

    partial void OnStudiosRead(ref IQueryable<Models.Suchimnu.Studio> items);

    partial void OnStudioGet(ref SingleResult<Models.Suchimnu.Studio> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{Id}")]
    public SingleResult<Studio> GetStudio(int key)
    {
        var items = this.context.Studios.Where(i=>i.Id == key);
        var result = SingleResult.Create(items);

        OnStudioGet(ref result);

        return result;
    }
    partial void OnStudioDeleted(Models.Suchimnu.Studio item);
    partial void OnAfterStudioDeleted(Models.Suchimnu.Studio item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteStudio(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.Studios
                .Where(i => i.Id == key)
                .Include(i => i.Games)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Suchimnu.Studio>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnStudioDeleted(item);
            this.context.Studios.Remove(item);
            this.context.SaveChanges();
            this.OnAfterStudioDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnStudioUpdated(Models.Suchimnu.Studio item);
    partial void OnAfterStudioUpdated(Models.Suchimnu.Studio item);

    [HttpPut("{Id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutStudio(int key, [FromBody]Models.Suchimnu.Studio newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.Studios
                .Where(i => i.Id == key)
                .Include(i => i.Games)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Suchimnu.Studio>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnStudioUpdated(newItem);
            this.context.Studios.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Studios.Where(i => i.Id == key);
            this.OnAfterStudioUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{Id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchStudio(int key, [FromBody]Delta<Models.Suchimnu.Studio> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.Studios.Where(i => i.Id == key);

            items = EntityPatch.ApplyTo<Models.Suchimnu.Studio>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnStudioUpdated(item);
            this.context.Studios.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Studios.Where(i => i.Id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnStudioCreated(Models.Suchimnu.Studio item);
    partial void OnAfterStudioCreated(Models.Suchimnu.Studio item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Suchimnu.Studio item)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (item == null)
            {
                return BadRequest();
            }

            this.OnStudioCreated(item);
            this.context.Studios.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Suchimnu/Studios/{item.Id}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
