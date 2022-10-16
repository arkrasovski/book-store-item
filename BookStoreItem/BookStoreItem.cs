using System.Globalization;

namespace BookStoreItem
{
    /// <summary>
    /// Represents the an item in a book store.
    /// </summary>
    // TODO Declare a class.
    public class BookStoreItem
    {
        // TODO Add fields.
        private readonly string authorName;
        private readonly string isni;
        private readonly bool hasIsni;
        private decimal price;
        private string currency;
        private int amount;
        /// <summary>
        /// Initializes a new instance of the <see cref="BookStoreItem"/> class with the specified <paramref name="authorName"/>, <paramref name="title"/>, <paramref name="publisher"/> and <paramref name="isbn"/>.
        /// </summary>
        /// <param name="authorName">A book author's name.</param>
        /// <param name="title">A book title.</param>
        /// <param name="publisher">A book publisher.</param>
        /// <param name="isbn">A book ISBN.</param>
        // TODO Add a constructor.

        /// <summary>
        /// Initializes a new instance of the <see cref="BookStoreItem"/> class with the specified <paramref name="authorName"/>, <paramref name="isni"/>, <paramref name="title"/>, <paramref name="publisher"/> and <paramref name="isbn"/>.
        /// </summary>
        /// <param name="authorName">A book author's name.</param>
        /// <param name="isni">A book author's ISNI.</param>
        /// <param name="title">A book title.</param>
        /// <param name="publisher">A book publisher.</param>
        /// <param name="isbn">A book ISBN.</param>
        // TODO Add a constructor.

        /// <summary>
        /// Initializes a new instance of the <see cref="BookStoreItem"/> class with the specified <paramref name="authorName"/>, <paramref name="title"/>, <paramref name="publisher"/> and <paramref name="isbn"/>, <paramref name="published"/>, <paramref name="bookBinding"/>, <paramref name="price"/>, <paramref name="currency"/> and <paramref name="amount"/>.
        /// </summary>
        /// <param name="authorName">A book author's name.</param>
        /// <param name="title">A book title.</param>
        /// <param name="publisher">A book publisher.</param>
        /// <param name="isbn">A book ISBN.</param>
        /// <param name="published">A book publishing date.</param>
        /// <param name="bookBinding">A book binding type.</param>
        /// <param name="price">An amount of money that a book costs.</param>
        /// <param name="currency">A price currency.</param>
        /// <param name="amount">An amount of books in the store's stock.</param>
        // TODO Add a constructor.

        /// <summary>
        /// Initializes a new instance of the <see cref="BookStoreItem"/> class with the specified <paramref name="authorName"/>, <paramref name="isni"/>, <paramref name="title"/>, <paramref name="publisher"/> and <paramref name="isbn"/>, <paramref name="published"/>, <paramref name="bookBinding"/>, <paramref name="price"/>, <paramref name="currency"/> and <paramref name="amount"/>.
        /// </summary>
        /// <param name="authorName">A book author's name.</param>
        /// <param name="isni">A book author's ISNI.</param>
        /// <param name="title">A book title.</param>
        /// <param name="publisher">A book publisher.</param>
        /// <param name="isbn">A book ISBN.</param>
        /// <param name="published">A book publishing date.</param>
        /// <param name="bookBinding">A book binding type.</param>
        /// <param name="price">An amount of money that a book costs.</param>
        /// <param name="currency">A price currency.</param>
        /// <param name="amount">An amount of books in the store's stock.</param>
        public BookStoreItem(string authorName, string isni, string title, string publisher, string isbn, DateTime? published, decimal price, int amount, string bookBinding = "", string currency = "USD")
        {
            this.authorName = authorName;
            this.isni = isni;
            this.Title = title;
            this.Publisher = publisher;

        }

        /// <summary>
        /// Gets a book author's name.
        /// </summary>
        public string AuthorName
        {
            get { return this.authorName; }
        }

        /// <summary>
        /// Gets an International Standard Name Identifier (ISNI) that uniquely identifies a book author.
        /// </summary>
        public string Isni
        {
            get { return this.isni; }
        }

        /// <summary>
        /// Gets a value indicating whether an author has an International Standard Name Identifier (ISNI).
        /// </summary>
        public bool HasIsni
        {
            get => this.hasIsni;
        }

        /// <summary>
        /// Gets a book title.
        /// </summary>
        public string Title
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a book publisher.
        /// </summary>
        public string Publisher
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a book International Standard Book Number (ISBN).
        /// </summary>
        public string Isbn
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets a book publishing date.
        /// </summary>
        public DateTime? Published
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a book binding type.
        /// </summary>
        public string BookBinding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets an amount of money that a book costs.
        /// </summary>
        private decimal Price
        {
            get => this.price;

            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Error: price is lower zero");
                }
            }
        }

        /// <summary>
        /// Gets or sets a price currency.
        /// </summary>
        private string Currency
        {
            get => this.currency;
            set
            {
                if (ThrowExceptionIfCurrencyIsNotValid(value))
                {
                    this.currency = value;
                }
                else
                {
                    this.currency = string.Empty;
                }

                //тут надо написать else и использовать функцию ThrowExceptionIfCurrencyIsNotValid
            }
        }

        /// <summary>
        /// Gets or sets an amount of books in the store's stock.
        /// </summary>
        public int Amount
        {
            get => this.amount;
            set
            {
                if (value >= 0)
                {
                    this.amount = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Error: amount is lower zero");
                }
            }
        }

        /// <summary>
        /// Gets a <see cref="Uri"/> to the contributor's page at the isni.org website.
        /// </summary>
        /// <returns>A <see cref="Uri"/> to the contributor's page at the isni.org website.</returns>
        // TODO Add an instance method.

        /// <summary>
        /// Gets an <see cref="Uri"/> to the publication page on the isbnsearch.org website.
        /// </summary>
        /// <returns>an <see cref="Uri"/> to the publication page on the isbnsearch.org website.</returns>
        // TODO Add an instance method.

        /// <summary>
        /// Returns the string that represents a current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        // TODO Add an instance method.

        private static bool ThrowExceptionIfCurrencyIsNotValid(string value)
        {
            bool isCurrency = true;
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    isCurrency = false;
                }
            }

            if (isCurrency && value.Length == 3)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Its not a currency");
            }
        }

        // TODO Add a static method.

        // TODO Add a static method.

        // TODO Add a static method.
    }
}
