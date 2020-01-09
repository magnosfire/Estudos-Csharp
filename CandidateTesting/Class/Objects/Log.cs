using System;

namespace CandidateTesting.RenanRossinideOlivera.AgileExercices.Class
{
    class Log: Object
    {

        public string provider { get; set; }
        public string httpMethod { get; set; }
        public int statusCode { get; set; }
        public string uriPath { get; set; }
        public int timeTaken { get; set; }
        public int responseSize { get; set; }
        public string cacheStatus { get; set; }

    }
}
