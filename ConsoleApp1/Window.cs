class Window {
    //contructor takes two integers to 
    //fix location on the console
    public Window(int top, int left) {
        this.top = top;
        this.left = left;
    }
    //simulates drawing the window
    public virtual void DrawWindow () {
        Console.WriteLine("Window: drawing Window at {0}, {1}", top, left);
    }
    //these members are protectec and thus visiable
    //to derived class methods. we'll examine this
    //later in the chapter
    protected int top;
    protected int left;
}