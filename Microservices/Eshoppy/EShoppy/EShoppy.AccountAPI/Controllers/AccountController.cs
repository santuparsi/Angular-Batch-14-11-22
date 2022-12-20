using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.AccountAPI.Services;
using EShoppy.AccountAPI.Entities;
using EShoppy.AccountAPI.Model;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace EShoppy.AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService userService;
        //private readonly ILogger _logger;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
            //this._logger = logger;
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(User user)
        {
            try
            {
                userService.Register(user);
                return Ok();
            }
            catch (Exception ex)
            {
               // _logger.LogInformation(ex.Message);
                return NotFound(ex.Message);


            }
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(Login login)
        {
            try
            {
                AuthUser authUser = null;
                User user = userService.Login(login);
                if (user != null)
                {
                    authUser = new AuthUser()
                    {
                        UserId = user.UserId,
                        Name = user.Name,
                        Token = GetToken(user),
                        Role = user.Role
                    };
                }

                return Ok(authUser);

            }
            catch (Exception ex)
            {
                //_logger.LogInformation(ex.Message);
                return NotFound(ex.Message);

            }
        }
        private string GetToken(User user)
        {
            var _config = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json").Build();
            var issuer = _config["Jwt:Issuer"];
            var audience = _config["Jwt:Audience"];
            //var expiry = DateTime.Now.AddMinutes(120);
            var securityKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials
        (securityKey, SecurityAlgorithms.HmacSha256);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                   {
                    new Claim(ClaimTypes.Name, user.UserId.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                   }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }
    }
}
