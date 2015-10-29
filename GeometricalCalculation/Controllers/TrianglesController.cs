using GeometricalCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GeometricalCalculation.Controllers
{
    public class TrianglesController : ApiController
    {
        Triangle triangle = new Triangle();


        public IHttpActionResult GetTriangle(double baseWidth, double height)
        {
            triangle.Base = baseWidth;
            triangle.Height = height;
            triangle.Area = baseWidth * height * 0.5;

            return Ok(triangle);
        }

    }
}
