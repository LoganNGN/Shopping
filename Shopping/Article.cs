using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Shopping
{
    public class Article
    {
        #region private attributes
        private int _id;
        private string _description = "";
        private float _price = 0f;
        #endregion private attributes

        #region public methods
        public Article(int id, string description, float price)
        {
            _description = description;
            _id = id;
            _price = price;
        }


        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                switch (value.Length)
                {
                    case < 10:
                        throw new TooShortDescriptionException();
                    case > 50:
                        throw new TooLongDescriptionException();
                    default: 
                        break;
                }
                Regex rgx = new Regex("[^A-Za-z0-9 ]");
                bool containsSpecialCharacter = rgx.IsMatch(value);
                if (containsSpecialCharacter)
                {
                    throw new SpecialCharInDescriptionException();
                }
                _description = value;
            }
        }

        public float Price
        {
            get
            {
                return _price;
            }
        }
        #endregion public methods

        public class ArticleException : Exception { }
        public class TooShortDescriptionException : ArticleException { }
        public class SpecialCharInDescriptionException : ArticleException { }
        public class TooLongDescriptionException : ArticleException { }
    }
}
