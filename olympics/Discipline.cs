using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace olympics
{
    class Discipline
    {
        // attributes.
        private string disciplineCode;
        private string disciplineDescription;

        private BusinessLayer businessLayer = new BusinessLayer();

        // constructor.
        public Discipline()
        { }
        public Discipline(string disciplineCode, string disciplineDescription)
        {
            this.disciplineCode = disciplineCode;
            this.disciplineDescription = disciplineDescription;
        }

        // properties.
        public string DisciplineCode
        {
            set { disciplineCode = value; }
            get { return disciplineCode; }
        }
        public string DisciplineDescription
        {
            set { disciplineDescription = value; }
            get { return disciplineDescription; }
        }

        // business layer communication.
        public DataTable AllDiscipline()
        {
            return businessLayer.SelectDiscipline();
        }
        public string PlacingDisciplineDesc(string disciplineCode)
        {
            return businessLayer.SelectPlacingDisciplineDesc(disciplineCode);
        }
        public string EventDisciplineDesc(string disciplineCode)
        {
            return businessLayer.SelectEventDisciplineDesc(disciplineCode);
        }
        public int AddDiscipline(string disciplineCode, string disciplineDescription)
        {
            return businessLayer.InsertDiscipline(disciplineCode, disciplineDescription);
        }
        public int EditDiscipline(string disciplineCode, string disciplineDescription)
        {
            return businessLayer.UpdateDiscipline(disciplineCode, disciplineDescription);
        }
        public int RemoveDiscipline(string disciplineCode)
        {
            return businessLayer.DeleteDiscipline(disciplineCode);
        }

    }
}
