
namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public string AreEqual()
        {
            bool result = this.left.Equals(this.right);
            return result.ToString();
        }
      
    }
}
