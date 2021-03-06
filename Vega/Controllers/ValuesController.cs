﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Vega.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private IConfiguration _config;

        public ValuesController(IConfiguration configuration)
        {
            _config = configuration;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            using(SqlConnection conexao = new SqlConnection(_config.GetConnectionString("CnnStr")))
            {
                return conexao.Query<string>("");
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
