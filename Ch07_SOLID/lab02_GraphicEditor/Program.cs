namespace lab02_GraphicEditor
{
    public class Program
    {
        public static void Main()
        {
            // Done
            GraphicEditor graphicEditor = new GraphicEditor();

            IShape rectangle = new Rectangle();
            graphicEditor.DrawShape(rectangle);

            IShape circle = new Circle();
            graphicEditor.DrawShape(circle);

            IShape square = new Square();
            graphicEditor.DrawShape(square);
        }
    }
}
