using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class TypeBorne
    {
        private string codeTypeBorne;

        private int duréeRévision, nbJoursEntreRevisionns, nbUnitesEntreRevisions;

        #region Constructeur
        public TypeBorne()
        {
        }

        public TypeBorne(string unCode, int uneDurée, int unNbJours, int unNbUnités)
        {
            this.codeTypeBorne = unCode;
            this.duréeRévision = uneDurée;
            this.nbJoursEntreRevisionns = unNbJours;
            this.nbUnitesEntreRevisions = unNbUnités;
        }
        #endregion

        #region GET & SET
        public string CodeTypeBorne
        {
            get { return codeTypeBorne; }
            set { codeTypeBorne = value; }
        }

        public int NbUnitesEntreRevisions
        {
            get { return nbUnitesEntreRevisions; }
            set { nbUnitesEntreRevisions = value; }
        }

        public int NbJoursEntreRevisionns
        {
            get { return nbJoursEntreRevisionns; }
            set { nbJoursEntreRevisionns = value; }
        }

        public int DuréeRévision
        {
            get { return duréeRévision; }
            set { duréeRévision = value; }
        }
        #endregion

    }
}
