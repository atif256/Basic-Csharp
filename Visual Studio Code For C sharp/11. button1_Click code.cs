private void button1_Click(object sender, EventArgs e)
    {
        int n1 = int.Parse(textBox1.Text);
        int n2 = int.Parse(textBox2.Text);
        int total = n1 + n2;
        label1.Text = total.ToString();

    }

