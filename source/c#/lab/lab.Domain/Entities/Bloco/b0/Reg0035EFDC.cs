﻿
namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0035EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public int CodSCP { get; set; }
        public string DescSCP { get; set; }
        public string InfoCompl { get; set; }
        public int Reg0000EFDCId { get; set; }
        public virtual Reg0000EFDC Reg0000EFDC { get; set; }
    }
}
