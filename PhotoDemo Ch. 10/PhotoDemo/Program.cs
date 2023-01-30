using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class PhotoDemo
{
    static void Main(string[] args)
    {
        Photo photo = new Photo(8, 10);
        MattedPhoto mattedPhoto = new MattedPhoto(10, 12, "Green");
        FramedPhoto framedPhoto = new FramedPhoto(15, 20, "Silver", "Modern");
        WriteLine(photo.ToString());
        WriteLine(mattedPhoto.ToString());
        WriteLine(framedPhoto.ToString());
    }
}

class Photo
{
    private int width;
    private int height;
    protected double price;

    public Photo(int w, int h)
    {
        this.width = w;
        this.height = h;
        price = getPrice(w, h);
    }
    public int Width { get; set; }
    public int Height { get; set; }
    public double getPrice(int width, int height)
    {
        double price;
        if (width == 8 && height == 10)
        {
            price = 3.99;
        }
        else if (width == 10 && height == 12)
        {
            price = 5.99;
        }
        else
        {
            price = 9.99;
        }
        return price;
    }
    public override string ToString()
    {
        return string.Format("Type: {0}, Width: {1}, Height: {2}, Price: {3}", this.GetType(), width, height, price.ToString("C"));
    }
}

class MattedPhoto : Photo
{
    private string color;
    public MattedPhoto(int w, int h, string c) : base(w, h)
    {
        Width = w;
        Height = h;
        color = c;
        price = getPrice(w, h) + 10;
    }

    public override string ToString()
    {
        return base.ToString() + ", Color: " + color;
    }

}

class FramedPhoto : Photo
{
    private string material;
    private string style;
    //constructor method
    public FramedPhoto(int w, int h, string m, string s) : base(w, h)
    {
        Width = w;
        Height = h;
        material = m;
        style = s;
        price = getPrice(w, h) + 25;
    }


    public override string ToString()
    {
        return base.ToString() + ", Material: " + material + ", Style: " + style;
    }
}
