using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleNLayerProject.API.Responses
{
    public class GenericResultList<T> where T : class
    {
        public List<T> result { get; set; }
    }
}
