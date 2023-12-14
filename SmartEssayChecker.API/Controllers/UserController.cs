using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
using SmartEssayChecker.API.Brokers.Storages;
using SmartEssayChecker.API.Models.Users;

namespace SmartEssayChecker.API.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : RESTFulController
{
    private readonly IStorageBroker storageBroker;

    public UserController(IStorageBroker storageBroker)
    {
        this.storageBroker = storageBroker;
    }

    [HttpPost]
    public async ValueTask<ActionResult<User>> AddUser(User user)
    {
        var persistedUser = await this.storageBroker.InsertUserAsync(user);
        return Created(persistedUser);
    }
}