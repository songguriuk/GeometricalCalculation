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

        private Triangle triangle;
        private string errorMessage;

        public HttpResponseMessage GetTriangle(string id, double baseWidth, double height)
        {
            this.triangle = new Triangle{
                TriangleId = id,
                Base = baseWidth,
                Height = height,
                Area = Math.Abs(baseWidth * height)/2
            };
                
            if(Validate())
            {
                return Request.CreateResponse<Triangle>(HttpStatusCode.OK, triangle);
            }
                
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, errorMessage);
            }
            
        }

        public HttpResponseMessage Get()
        {
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, new Exception("No valid input parameter is given. Please try with valid URL. it is /api/triangles/{id}/{base}/{height}"));
        }

        private bool Validate()
        {

            if (ValidLength(triangle.Base) && ValidLength(triangle.Height) && ValidLength(triangle.Area))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private bool ValidLength(Double value)
        {
            bool isValid = true;

            if (value == 0)
            {
                errorMessage = string.Format("Input value shouldn't be zero.", value);
                isValid = false;
            }
            else if(value.ToString().Length > 9 || Math.Round((decimal)value) > 100)
            {
                errorMessage = string.Format("{0} is  not valid range.", value);
                isValid = false;
            }
            
            return isValid;
        }
    }
}
