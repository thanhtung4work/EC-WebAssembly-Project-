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

  [ODataRoutePrefix("odata/suchimnu/Stats")]
  [Route("mvc/odata/suchimnu/Stats")]
  public partial class StatsController : ODataController
  {
    private Data.SuchimnuContext context;

    public StatsController(Data.SuchimnuContext context)
    {
      this.context = context;
    }
    // GET /odata/Suchimnu/Stats
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Suchimnu.Stat> GetStats()
    {
      var items = this.context.Stats.AsQueryable<Models.Suchimnu.Stat>();
      this.OnStatsRead(ref items);

      return items;
    }

    partial void OnStatsRead(ref IQueryable<Models.Suchimnu.Stat> items);

    partial void OnStatGet(ref SingleResult<Models.Suchimnu.Stat> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{Id}")]
    public SingleResult<Stat> GetStat(int key)
    {
        var items = this.context.Stats.Where(i=>i.Id == key);
        var result = SingleResult.Create(items);

        OnStatGet(ref result);

        return result;
    }
    partial void OnStatDeleted(Models.Suchimnu.Stat item);
    partial void OnAfterStatDeleted(Models.Suchimnu.Stat item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteStat(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.Stats
                .Where(i => i.Id == key)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Suchimnu.Stat>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnStatDeleted(item);
            this.context.Stats.Remove(item);
            this.context.SaveChanges();
            this.OnAfterStatDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnStatUpdated(Models.Suchimnu.Stat item);
    partial void OnAfterStatUpdated(Models.Suchimnu.Stat item);

    [HttpPut("{Id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutStat(int key, [FromBody]Models.Suchimnu.Stat newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.Stats
                .Where(i => i.Id == key)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Suchimnu.Stat>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnStatUpdated(newItem);
            this.context.Stats.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Stats.Where(i => i.Id == key);
            this.OnAfterStatUpdated(newItem);
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
    public IActionResult PatchStat(int key, [FromBody]Delta<Models.Suchimnu.Stat> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.Stats.Where(i => i.Id == key);

            items = EntityPatch.ApplyTo<Models.Suchimnu.Stat>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnStatUpdated(item);
            this.context.Stats.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Stats.Where(i => i.Id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnStatCreated(Models.Suchimnu.Stat item);
    partial void OnAfterStatCreated(Models.Suchimnu.Stat item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Suchimnu.Stat item)
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

            this.OnStatCreated(item);
            this.context.Stats.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Suchimnu/Stats/{item.Id}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
