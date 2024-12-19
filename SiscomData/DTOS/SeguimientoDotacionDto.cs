using System;

namespace SiscomData.DTOS
{
    public class SeguimientoDotacionDto
    {
        public int Cliente { get; set; }       
        public string Codigo { get; set; }    
        public int EnvContEnv { get; set; }    
        public int EnvContSeg { get; set; }  
    }
}