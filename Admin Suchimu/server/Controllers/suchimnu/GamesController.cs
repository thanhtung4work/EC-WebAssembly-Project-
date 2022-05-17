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

  [ODataRoutePrefix("odata/suchimnu/Games")]
  [Route("mvc/odata/suchimnu/Games")]
  public partial class GamesController : ODataController
  {
    private Data.SuchimnuContext context;

    public GamesController(Data.SuchimnuContext context)
    {
      this.context = context;
    }
    // GET /odata/Suchimnu/Games
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Suchimnu.Game> GetGames()
    {
      var items = this.context.Games.AsQueryable<Models.Suchimnu.Game>();
      this.OnGamesRead(ref items);

      return items;
    }

    partial void OnGamesRead(ref IQueryable<Models.Suchimnu.Game> items);

    partial void OnGameGet(ref SingleResult<Models.Suchimnu.Game> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{Id}")]
    public SingleResult<Game> GetGame(int key)
    {
        var items = this.context.Games.Where(i=>i.Id == key);
        var result = SingleResult.Create(items);

        OnGameGet(ref result);

        return result;
    }
    partial void OnGameDeleted(Models.Suchimnu.Game item);
    partial void OnAfterGameDeleted(Models.Suchimnu.Game item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteGame(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.Games
                .Where(i => i.Id == key)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Suchimnu.Game>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnGameDeleted(item);
            this.context.Games.Remove(item);
            this.context.SaveChanges();
            this.OnAfterGameDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnGameUpdated(Models.Suchimnu.Game item);
    partial void OnAfterGameUpdated(Models.Suchimnu.Game item);

    [HttpPut("{Id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutGame(int key, [FromBody]Models.Suchimnu.Game newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.Games
                .Where(i => i.Id == key)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Suchimnu.Game>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnGameUpdated(newItem);
            this.context.Games.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Games.Where(i => i.Id == key);
            Request.QueryString = Request.QueryString.Add("$expand", "Category,Studio");
            this.OnAfterGameUpdated(newItem);
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
    public IActionResult PatchGame(int key, [FromBody]Delta<Models.Suchimnu.Game> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.Games.Where(i => i.Id == key);

            items = EntityPatch.ApplyTo<Models.Suchimnu.Game>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnGameUpdated(item);
            this.context.Games.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Games.Where(i => i.Id == key);
            Request.QueryString = Request.QueryString.Add("$expand", "Category,Studio");
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnGameCreated(Models.Suchimnu.Game item);
    partial void OnAfterGameCreated(Models.Suchimnu.Game item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Suchimnu.Game item)
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

            this.OnGameCreated(item);
            this.context.Games.Add(item);
            this.context.SaveChanges();

            var key = item.Id;

            var itemToReturn = this.context.Games.Where(i => i.Id == key);

            Request.QueryString = Request.QueryString.Add("$expand", "Category,Studio");

            this.OnAfterGameCreated(item);

            return new ObjectResult(SingleResult.Create(itemToReturn))
            {
                StatusCode = 201
            };
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
