﻿using FunnyWaterCarrier.Data.Model;

namespace FunnyWaterCarrier.Data.Stub
{
    public class SubdivisionStub
    {
        private static List<Subdivision> _subdivisions;
        public List<Subdivision> Subdivisions { get => _subdivisions; set => _subdivisions = value; }

        public SubdivisionStub()
        {
            _subdivisions = new List<Subdivision>()
            {
                new Subdivision() { Id = 0, Name = "Отдел смешарики", SupervisorId = 1 },
                new Subdivision() { Id = 1, Name = "Отдел трудяги", SupervisorId = 0 }
            };
        }
    }
}