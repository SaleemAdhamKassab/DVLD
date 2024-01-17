using DVLD_DataAccess;
using Sahred.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class TestType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }


        public static TestTypeDto get(int id) => TestTypeData.get(id);

        public static DataTable get() => TestTypeData.get();

        public static decimal getTestTypeFees(byte testTypeId) => TestTypeData.getTestTypeFees(testTypeId);

        public static bool put(TestTypeDto testTypeDto) => TestTypeData.put(testTypeDto);

    }
}
