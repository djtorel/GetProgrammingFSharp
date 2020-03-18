open System.Windows.Forms

//let form = new Form()
//
//form.Show()
//form.Width <- 400
//form.Height <- 400
//form.Text <- "Hello from F#!"

let form = new Form(Text = "Hello from F#!", Width = 300, Height = 300)
form.Show()