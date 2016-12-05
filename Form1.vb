Public Class Form1

    Public selectedIndex As Integer

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles panPizza.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This shows time of the day and a date in the lables at the top of the form.
        lblTime.Text = TimeOfDay
        lblDate.Text = Today

        'This will display the main form which probably will be chosen first as it is pizza
        panPizza.Visible = True

        btnPizza.Enabled = False

    End Sub

    Private Sub btnPizza_Click(sender As Object, e As EventArgs) Handles btnPizza.Click

        'I hided all unnecessary panels
        panPizza.Visible = True
        panStarters.Visible = False
        panDesserts.Visible = False
        panDrinks.Visible = False
        panBurgerSalad.Visible = False
        panCans.Visible = False
        panBottle.Visible = False
        panSize.Visible = False

    End Sub

    Private Sub btnStarters_Click(sender As Object, e As EventArgs) Handles btnStarters.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panStarters.Visible = True
        panDesserts.Visible = False
        panDrinks.Visible = False
        panBurgerSalad.Visible = False
        panCans.Visible = False
        panBottle.Visible = False
        panSize.Visible = False

    End Sub

    Private Sub btnDesserts_Click(sender As Object, e As EventArgs) Handles btnDesserts.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panStarters.Visible = False
        panDesserts.Visible = True
        panDrinks.Visible = False
        panBurgerSalad.Visible = False
        panCans.Visible = False
        panBottle.Visible = False
        panSize.Visible = False

    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panStarters.Visible = False
        panDesserts.Visible = False
        panDrinks.Visible = True
        panBurgerSalad.Visible = False
        panCans.Visible = False
        panBottle.Visible = False
        panSize.Visible = False

    End Sub

    Private Sub btnBurgerSalads_Click(sender As Object, e As EventArgs) Handles btnBurgerSalads.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panStarters.Visible = False
        panDesserts.Visible = False
        panDrinks.Visible = False
        panBurgerSalad.Visible = True
        panCans.Visible = False
        panBottle.Visible = False
        panSize.Visible = False

    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles btnCans.Click

        'I hided all unnecessary panels
        panCans.Visible = True
        panDrinks.Visible = False

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnBottle.Click

        'I hided all unnecessary panels
        panBottle.Visible = True
        panDrinks.Visible = False

    End Sub

    Private Sub btnMargherita_Click(sender As Object, e As EventArgs) Handles btnMargherita.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panSize.Visible = True

        'I added item to the list
        lstItemName.Items.Add("Margherita")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnAmericanhot_Click(sender As Object, e As EventArgs) Handles btnAmericanhot.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panSize.Visible = True

        'I added item to the list
        lstItemName.Items.Add("American hot")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnCheesetomato_Click(sender As Object, e As EventArgs) Handles btnCheesetomato.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panSize.Visible = True

        'I added item to the list
        lstItemName.Items.Add("Cheese and tomato")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnBeefeater_Click(sender As Object, e As EventArgs) Handles btnBeefeater.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panSize.Visible = True

        'I added item to the list
        lstItemName.Items.Add("Beefeater")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnHampineapple_Click(sender As Object, e As EventArgs) Handles btnHampineapple.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panSize.Visible = True

        'I added item to the list
        lstItemName.Items.Add("Ham and pineapple")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnVegetarianhot_Click(sender As Object, e As EventArgs) Handles btnVegetarianhot.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panSize.Visible = True

        'I added item to the list
        lstItemName.Items.Add("Vegetarian hot")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnMediterraneanspecial_Click(sender As Object, e As EventArgs) Handles btnMediterraneanspecial.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panSize.Visible = True

        'I added item to the list
        lstItemName.Items.Add("Mediterranean special")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnTandooriexpress_Click(sender As Object, e As EventArgs) Handles btnTandooriexpress.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panSize.Visible = True

        'I added item to the list
        lstItemName.Items.Add("Tandoori express")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnMeatfeast_Click(sender As Object, e As EventArgs) Handles btnMeatfeast.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panSize.Visible = True

        'I added item to the list
        lstItemName.Items.Add("Meat feast")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnSeafood_Click(sender As Object, e As EventArgs) Handles btnSeafood.Click

        'I hided all unnecessary panels
        panPizza.Visible = False
        panSize.Visible = True

        'I added item to the list
        lstItemName.Items.Add("Seafood")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub lstTotalPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTotalPrice.SelectedIndexChanged

    End Sub

    Private Sub btn9M_Click(sender As Object, e As EventArgs) Handles btn9M.Click

        'I hided all unnecessary panels
        panSize.Visible = False
        panQuantity.Visible = True

        'I added size to the list
        lstSize.Items.Add("9 M")

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles panQuantity.Paint

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        'This types one into the textbox and so on...
        txtQuantity.Text += "1"

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        txtQuantity.Text += "2"

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click

        txtQuantity.Text += "3"

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click

        txtQuantity.Text += "4"

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click

        txtQuantity.Text += "5"

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click

        txtQuantity.Text += "6"

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click

        txtQuantity.Text += "7"

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click

        txtQuantity.Text += "8"

    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click

        txtQuantity.Text += "9"

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click

        txtQuantity.Text += "0"

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        'this adds the number in the textbox to the quantity listbox
        lstQuantity.Items.Add(txtQuantity.Text)

        'this defines that the textbox is a value 
        Dim Q As Long
        Q = Val(txtQuantity.Text)

        'this defines the last item in the listbox
        Dim lastItem As String
        lastItem = lstItemName.Items(lstItemName.Items.Count() - 1).ToString()

        'this defines the last size in the listbox
        Dim size As String
        size = lstSize.Items(lstSize.Items.Count() - 1).ToString()

        'this is a list of statements looking at what is the last item in the item listbox and if so, the price of the product is calculated by the quantity
        If lastItem = "Margherita" And size = "9 M" Then
            lstTotalPrice.Items.Add(Q * 5.0)
        ElseIf lastItem = "Margherita" And size = "12 L" Then
            lstTotalPrice.Items.Add(Q * 7.0)
        ElseIf lastItem = "Margherita" And size = "15 XL" Then
            lstTotalPrice.Items.Add(Q * 9.0)
        ElseIf lastItem = "Margherita" And size = "18 XXL" Then
            lstTotalPrice.Items.Add(Q * 11.0)

        ElseIf lastItem = "American hot" And size = "9 M" Then
            lstTotalPrice.Items.Add(Q * 7.75)
        ElseIf lastItem = "American hot" And size = "12 L" Then
            lstTotalPrice.Items.Add(Q * 9.75)
        ElseIf lastItem = "American hot" And size = "15 XL" Then
            lstTotalPrice.Items.Add(Q * 11.75)
        ElseIf lastItem = "American hot" And size = "18 XXL" Then
            lstTotalPrice.Items.Add(Q * 13.75)

        ElseIf lastItem = "Cheese and tomato" And size = "9 M" Then
            lstTotalPrice.Items.Add(Q * 5.5)
        ElseIf lastItem = "Cheese and tomato" And size = "12 L" Then
            lstTotalPrice.Items.Add(Q * 7.5)
        ElseIf lastItem = "Cheese and tomato" And size = "15 XL" Then
            lstTotalPrice.Items.Add(Q * 9.5)
        ElseIf lastItem = "Cheese and tomato" And size = "18 XXL" Then
            lstTotalPrice.Items.Add(Q * 11.5)

        ElseIf lastItem = "Beefeater" And size = "9 M" Then
            lstTotalPrice.Items.Add(Q * 6.75)
        ElseIf lastItem = "Beefeater" And size = "12 L" Then
            lstTotalPrice.Items.Add(Q * 8.75)
        ElseIf lastItem = "Beefeater" And size = "15 XL" Then
            lstTotalPrice.Items.Add(Q * 10.75)
        ElseIf lastItem = "Beefeater" And size = "18 XXL" Then
            lstTotalPrice.Items.Add(Q * 12.75)

        ElseIf lastItem = "Ham and pineapple" And size = "9 M" Then
            lstTotalPrice.Items.Add(Q * 5.2)
        ElseIf lastItem = "Ham and pineapple" And size = "12 L" Then
            lstTotalPrice.Items.Add(Q * 7.2)
        ElseIf lastItem = "Ham and pineapple" And size = "15 XL" Then
            lstTotalPrice.Items.Add(Q * 9.2)
        ElseIf lastItem = "Ham and pineapple" And size = "18 XXL" Then
            lstTotalPrice.Items.Add(Q * 11.2)

        ElseIf lastItem = "Vegetarian hot" And size = "9 M" Then
            lstTotalPrice.Items.Add(Q * 6.75)
        ElseIf lastItem = "Vegetarian hot" And size = "12 L" Then
            lstTotalPrice.Items.Add(Q * 8.75)
        ElseIf lastItem = "Vegetarian hot" And size = "15 XL" Then
            lstTotalPrice.Items.Add(Q * 10.75)
        ElseIf lastItem = "Vegetarian hot" And size = "18 XXL" Then
            lstTotalPrice.Items.Add(Q * 12.75)

        ElseIf lastItem = "Mediterranean special" And size = "9 M" Then
            lstTotalPrice.Items.Add(Q * 6.2)
        ElseIf lastItem = "Mediterranean special" And size = "12 L" Then
            lstTotalPrice.Items.Add(Q * 8.2)
        ElseIf lastItem = "Mediterranean special" And size = "15 XL" Then
            lstTotalPrice.Items.Add(Q * 10.2)
        ElseIf lastItem = "Mediterranean special" And size = "18 XXL" Then
            lstTotalPrice.Items.Add(Q * 12.2)

        ElseIf lastItem = "Tandoori express" And size = "9 M" Then
            lstTotalPrice.Items.Add(Q * 6.75)
        ElseIf lastItem = "Tandoori express" And size = "12 L" Then
            lstTotalPrice.Items.Add(Q * 8.75)
        ElseIf lastItem = "Tandoori express" And size = "15 XL" Then
            lstTotalPrice.Items.Add(Q * 10.75)
        ElseIf lastItem = "Tandoori express" And size = "18 XXL" Then
            lstTotalPrice.Items.Add(Q * 12.75)

        ElseIf lastItem = "Meat feast" And size = "9 M" Then
            lstTotalPrice.Items.Add(Q * 6.75)
        ElseIf lastItem = "Meat feast" And size = "12 L" Then
            lstTotalPrice.Items.Add(Q * 8.75)
        ElseIf lastItem = "Meat feast" And size = "15 XL" Then
            lstTotalPrice.Items.Add(Q * 10.75)
        ElseIf lastItem = "Meat feast" And size = "18 XXL" Then
            lstTotalPrice.Items.Add(Q * 12.75)

        ElseIf lastItem = "Seafood" And size = "9 M" Then
            lstTotalPrice.Items.Add(Q * 6.0)
        ElseIf lastItem = "Seafood" And size = "12 L" Then
            lstTotalPrice.Items.Add(Q * 8.0)
        ElseIf lastItem = "Seafood" And size = "15 XL" Then
            lstTotalPrice.Items.Add(Q * 10.0)
        ElseIf lastItem = "Seafood" And size = "18 XXL" Then
            lstTotalPrice.Items.Add(Q * 12.0)



        ElseIf lastItem = "Quarter pounder" Then
            lstTotalPrice.Items.Add(Q * 2.5)
        ElseIf lastItem = "Fresh salad" Then
            lstTotalPrice.Items.Add(Q * 1.99)
        ElseIf lastItem = "Vegetable burger" Then
            lstTotalPrice.Items.Add(Q * 2.5)
        ElseIf lastItem = "Coleslaw" Then
            lstTotalPrice.Items.Add(Q * 199)
        ElseIf lastItem = "Fish burger" Then
            lstTotalPrice.Items.Add(Q * 2.5)
        ElseIf lastItem = "Humus" Then
            lstTotalPrice.Items.Add(Q * 1.99)
        ElseIf lastItem = "Chicken burger" Then
            lstTotalPrice.Items.Add(Q * 2.5)
        ElseIf lastItem = "Mixed green" Then
            lstTotalPrice.Items.Add(Q * 2.5)



        ElseIf lastItem = "Chocolate cake" Then
            lstTotalPrice.Items.Add(Q * 2.45)
        ElseIf lastItem = "Haggan Dazs" Then
            lstTotalPrice.Items.Add(Q * 5.5)
        ElseIf lastItem = "Tennessee cake" Then
            lstTotalPrice.Items.Add(Q * 2.45)
        ElseIf lastItem = "Vanilla" Then
            lstTotalPrice.Items.Add(Q * 5.0)
        ElseIf lastItem = "Strawberry cake" Then
            lstTotalPrice.Items.Add(Q * 2.45)
        ElseIf lastItem = "Strawberry" Then
            lstTotalPrice.Items.Add(Q * 5.0)
        ElseIf lastItem = "Banana fritter" Then
            lstTotalPrice.Items.Add(Q * 2.0)
        ElseIf lastItem = "Belgian chocolate" Then
            lstTotalPrice.Items.Add(Q * 5.0)
        ElseIf lastItem = "Pineapple fritter" Then
            lstTotalPrice.Items.Add(Q * 2.0)
        ElseIf lastItem = "Chokies Cream" Then
            lstTotalPrice.Items.Add(Q * 5.0)



        ElseIf lastItem = "Can Pepsi" Then
            lstTotalPrice.Items.Add(Q * 0.8)
        ElseIf lastItem = "Can Coke" Then
            lstTotalPrice.Items.Add(Q * 0.8)
        ElseIf lastItem = "Can Fanta" Then
            lstTotalPrice.Items.Add(Q * 0.8)
        ElseIf lastItem = "Btl Pepsi" Then
            lstTotalPrice.Items.Add(Q * 2.25)
        ElseIf lastItem = "Btl Coke" Then
            lstTotalPrice.Items.Add(Q * 2.25)
        ElseIf lastItem = "Btl Fanta" Then
            lstTotalPrice.Items.Add(Q * 2.25)



        ElseIf lastItem = "Garlic bread" Then
            lstTotalPrice.Items.Add(Q * 1.99)
        ElseIf lastItem = "Chips" Then
            lstTotalPrice.Items.Add(Q * 1.99)
        ElseIf lastItem = "Onion rings" Then
            lstTotalPrice.Items.Add(Q * 2.4)
        ElseIf lastItem = "Spicy chicken wings" Then
            lstTotalPrice.Items.Add(Q * 3.0)
        ElseIf lastItem = "Potato wedges" Then
            lstTotalPrice.Items.Add(Q * 2.5)
        ElseIf lastItem = "BQQ chicken wings" Then
            lstTotalPrice.Items.Add(Q * 3.0)
        ElseIf lastItem = "Chicken nuggets" Then
            lstTotalPrice.Items.Add(Q * 2.3)
        ElseIf lastItem = "Chicken spring roll" Then
            lstTotalPrice.Items.Add(Q * 2.5)
        ElseIf lastItem = "Vegetarian spring rolls" Then
            lstTotalPrice.Items.Add(Q * 2.5)
        ElseIf lastItem = "Garlic mushroom bread" Then
            lstTotalPrice.Items.Add(Q * 1.99)



        ElseIf lastItem = "Regular coffe" Then
            lstTotalPrice.Items.Add(Q * 1.5)
        ElseIf lastItem = "Regular tea" Then
            lstTotalPrice.Items.Add(Q * 1.5)
        ElseIf lastItem = "Pure orange juice" Then
            lstTotalPrice.Items.Add(Q * 2.5)
        ElseIf lastItem = "Cappuccino" Then
            lstTotalPrice.Items.Add(Q * 1.5)
        ElseIf lastItem = "Pure apple juice" Then
            lstTotalPrice.Items.Add(Q * 2.5)
        ElseIf lastItem = "Chocolate" Then
            lstTotalPrice.Items.Add(Q * 1.5)

        End If

        'I hided all unnecessary panels
        panQuantity.Visible = False

        'this is to clear the text box after its done
        txtQuantity.Text = ""

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = True
        btnStarters.Enabled = True
        btnDesserts.Enabled = True
        btnDrinks.Enabled = True
        btnBurgerSalads.Enabled = True
        Button3.Enabled = True





        'Dim i As Integer

        'For i = 0 To lstItemName.Items.Count - 1
        '    If i("Margherita") Then
        '        lstTotalPrice.Items.Add(Q * 5)
        '    End If
        'Next

        ' lstTotalPrice.Items.Add(55)

        'For Each i In lstItemName.Items
        '    If i.Contains("Margherita") Then
        '        lstTotalPrice.Items.Add(Q * 5)
        '    ElseIf i.Contains("Seafood") Then
        '        lstTotalPrice.Items.Add(Q * 2)
        '    End If
        'Next

        'For Each i In lstItemName.Items
        '    If i.Contains("Seafood") Then
        '        lstTotalPrice.Items.Add(Q * 2)
        '    End If
        'Next


        'For Each i As ListItem In lstItemName.Items
        'If i.contains Then

        'Next

        'Dim Q As Integer
        'Q = CInt(txtQuantity.Text)

        ' If lstItemName.FindStringExact = "Margherita" Then
        'lstTotalPrice.Text = Q * 5
        'End If

        'Convert.ToInt32(txtQuantity.Text)
        'Quantity = Convert.ToInt32(lstQuantity.Text)

        'If lstItemName.Text = "Margherita" Then
        '    lstTotalPrice.Text = (Q * 5)
        'End If

    End Sub

    Private Sub btnQuarterpounder_Click(sender As Object, e As EventArgs) Handles btnQuarterpounder.Click

        'I hided all unnecessary panels
        panBurgerSalad.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Quarter pounder")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnFreshSalad_Click(sender As Object, e As EventArgs) Handles btnFreshsalad.Click

        'I hided all unnecessary panels
        panBurgerSalad.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Fresh salad")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnVegetableBurger_Click(sender As Object, e As EventArgs) Handles btnVegetableburger.Click

        'I hided all unnecessary panels
        panBurgerSalad.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Vegetable burger")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnColeslaw_Click(sender As Object, e As EventArgs) Handles btnColeslaw.Click

        'I hided all unnecessary panels
        panBurgerSalad.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Coleslaw")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnFishBurger_Click(sender As Object, e As EventArgs) Handles btnFishburger.Click

        'I hided all unnecessary panels
        panBurgerSalad.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Fish burger")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnHumus_Click(sender As Object, e As EventArgs) Handles btnHumus.Click

        'I hided all unnecessary panels
        panBurgerSalad.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Humus")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnChickenBurger_Click(sender As Object, e As EventArgs) Handles btnChickenburger.Click

        'I hided all unnecessary panels
        panBurgerSalad.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Chicken burger")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnMixedGreen_Click(sender As Object, e As EventArgs) Handles btnMixedgreen.Click

        'I hided all unnecessary panels
        panBurgerSalad.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Mixed green")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub btnChocolateCake_Click(sender As Object, e As EventArgs) Handles btnChocolateCake.Click

        'I hided all unnecessary panels
        panDesserts.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Chocolate cake")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles btnHaaganDazs.Click

        'I hided all unnecessary panels
        panDesserts.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Haggan Dazs")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnTennesseecake_Click(sender As Object, e As EventArgs) Handles btnTennesseecake.Click

        'I hided all unnecessary panels
        panDesserts.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Tennessee cake")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnVanilla_Click(sender As Object, e As EventArgs) Handles btnVanilla.Click

        'I hided all unnecessary panels
        panDesserts.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Vanilla")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnStrawberrycake_Click(sender As Object, e As EventArgs) Handles btnStrawberrycake.Click

        'I hided all unnecessary panels
        panDesserts.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Strawberry cake")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnStrawberry_Click(sender As Object, e As EventArgs) Handles btnStrawberry.Click

        'I hided all unnecessary panels
        panDesserts.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Strawberry")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnBananafritter_Click(sender As Object, e As EventArgs) Handles btnBananafritter.Click

        'I hided all unnecessary panels
        panDesserts.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Banana fritter")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnBelgianchocolate_Click(sender As Object, e As EventArgs) Handles btnBelgianchocolate.Click

        'I hided all unnecessary panels
        panDesserts.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Belgian chocolate")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnPineapplefritter_Click(sender As Object, e As EventArgs) Handles btnPineapplefritter.Click

        'I hided all unnecessary panels
        panDesserts.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Pineapple fritter")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub bntChokiesCream_Click(sender As Object, e As EventArgs) Handles bntChokiesCream.Click

        'I hided all unnecessary panels
        panDesserts.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Chokies Cream")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnPepsi_Click(sender As Object, e As EventArgs) Handles btnPepsi.Click

        'I hided all unnecessary panels
        panCans.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Can Pepsi")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnCoke_Click(sender As Object, e As EventArgs) Handles btnCoke.Click

        'I hided all unnecessary panels
        panCans.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Can Coke")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnFanta_Click(sender As Object, e As EventArgs) Handles btnFanta.Click

        'I hided all unnecessary panels
        panCans.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Can Fanta")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnBtlPepsi_Click(sender As Object, e As EventArgs) Handles btnBtlPepsi.Click

        'I hided all unnecessary panels
        panBottle.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Btl Pepsi")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnBtlCoke_Click(sender As Object, e As EventArgs) Handles btnBtlCoke.Click

        'I hided all unnecessary panels
        panBottle.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Btl Coke")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnBtlFanta_Click(sender As Object, e As EventArgs) Handles btnBtlFanta.Click

        'I hided all unnecessary panels
        panBottle.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Btl Fanta")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnGarlicbread_Click(sender As Object, e As EventArgs) Handles btnGarlicbread.Click

        'I hided all unnecessary panels
        panStarters.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Garlic bread")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnChips_Click(sender As Object, e As EventArgs) Handles btnChips.Click

        'I hided all unnecessary panels
        panStarters.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Chips")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnOnionrings_Click(sender As Object, e As EventArgs) Handles btnOnionrings.Click

        'I hided all unnecessary panels
        panStarters.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Onion rings")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnSpicychickenwings_Click(sender As Object, e As EventArgs) Handles btnSpicychickenwings.Click

        'I hided all unnecessary panels
        panStarters.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Spicy chicken wings")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnPotatowedges_Click(sender As Object, e As EventArgs) Handles btnPotatowedges.Click

        'I hided all unnecessary panels
        panStarters.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Potato wedges")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnBBQchickenwings_Click(sender As Object, e As EventArgs) Handles btnBBQchickenwings.Click

        'I hided all unnecessary panels
        panStarters.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("BQQ chicken wings")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnChickennuggets_Click(sender As Object, e As EventArgs) Handles btnChickennuggets.Click

        'I hided all unnecessary panels
        panStarters.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Chicken nuggets")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnChickenspringroll_Click(sender As Object, e As EventArgs) Handles btnChickenspringroll.Click

        'I hided all unnecessary panels
        panStarters.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Chicken spring roll")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnVegetarianspringrolls_Click(sender As Object, e As EventArgs) Handles btnVegetarianspringrolls.Click

        'I hided all unnecessary panels
        panStarters.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Vegetarian spring rolls")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnGarlicmushroombread_Click(sender As Object, e As EventArgs) Handles btnGarlicmushroombread.Click

        'I hided all unnecessary panels
        panStarters.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Garlic mushroom bread")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnRegularcoffe_Click(sender As Object, e As EventArgs) Handles btnRegularcoffe.Click

        'I hided all unnecessary panels
        panDrinks.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Regular coffe")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnRegulartea_Click(sender As Object, e As EventArgs) Handles btnRegulartea.Click

        'I hided all unnecessary panels
        panDrinks.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Regular tea")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnPureorangejuice_Click(sender As Object, e As EventArgs) Handles btnPureorangejuice.Click

        'I hided all unnecessary panels
        panDrinks.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Pure orange juice")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnCappuccino_Click(sender As Object, e As EventArgs) Handles btnCappuccino.Click

        'I hided all unnecessary panels
        panDrinks.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Cappuccino")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnPureapplejuice_Click(sender As Object, e As EventArgs) Handles btnPureapplejuice.Click

        'I hided all unnecessary panels
        panDrinks.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Pure apple juice")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnChocolate_Click(sender As Object, e As EventArgs) Handles btnChocolate.Click

        'I hided all unnecessary panels
        panDrinks.Visible = False
        panQuantity.Visible = True

        'I added item and size to the list
        lstItemName.Items.Add("Chocolate")
        lstSize.Items.Add("-")

        'I disabled all the buttons so you have to finish the order
        btnPizza.Enabled = False
        btnStarters.Enabled = False
        btnDesserts.Enabled = False
        btnDrinks.Enabled = False
        btnBurgerSalads.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'this is a calaculate the total of quantity
        Dim a As Decimal
        a = 0
        For index = 0 To lstQuantity.Items.Count() - 1
            a = a + lstQuantity.Items(index)
        Next

        'this is a calculation for total price
        Dim b As Decimal
        b = 0
        For index = 0 To lstTotalPrice.Items.Count() - 1
            b = b + lstTotalPrice.Items(index)
        Next

        lblTP.Text = a
        lblST.Text = ("£" & b)
        lblVAT.Text = ("£" & b * 20 / 100)
        lblGT.Text = ("£" & b + Val(lblVAT.Text))

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'this clears all of the listboxes
        lstItemName.Items.Clear()
        lstQuantity.Items.Clear()
        lstSize.Items.Clear()
        lstTotalPrice.Items.Clear()

    End Sub

    Private Sub SetSelected(ByVal indx As Integer)

        lstItemName.SelectedIndex = -1
        lstQuantity.SelectedIndex = -1
        lstSize.SelectedIndex = -1
        lstTotalPrice.SelectedIndex = -1
        If indx >= 0 Then
            lstItemName.SetSelected(indx, True)
        End If


        'lstQuantity.SetSelected(selectedIndex, True)
        'lstSize.SetSelected(selectedIndex, True)
        'lstTotalPrice.SetSelected(selectedIndex, True)

    End Sub


    Private Sub lstQuantity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstQuantity.SelectedIndexChanged
        Dim i As Integer
        'i = lstQuantity.SelectedItem()
        i = lstQuantity.SelectedIndex()
        SetSelected(i)
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles btn12L.Click

        panSize.Visible = False
        panQuantity.Visible = True

        lstSize.Items.Add("12 L")
    End Sub

    Private Sub btn15XL_Click(sender As Object, e As EventArgs) Handles btn15XL.Click
        panSize.Visible = False
        panQuantity.Visible = True

        lstSize.Items.Add("15 XL")
    End Sub

    Private Sub btn18XXL_Click(sender As Object, e As EventArgs) Handles btn18XXL.Click
        panSize.Visible = False
        panQuantity.Visible = True

        lstSize.Items.Add("18 XXL")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

        If Not IsNumeric(txtPrice.Text) Then
            MessageBox.Show("Please put a positive number in this box")
        End If

    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        MessageBox.Show("The Order has been send to the till and kitchen")

        'Sends Quantity, Size and name of the product list to the kitchen + Table Number + additional request

        'Sends Quantity, Size, Name and Total Items, Sub-Total, VAT, Grand Total to the till for the receipt purposes + Table Number + additional request 

        'this clears all of the listboxes
        lstItemName.Items.Clear()
        lstQuantity.Items.Clear()
        lstSize.Items.Clear()
        lstTotalPrice.Items.Clear()

        lblTP.Text = ("-")
        lblST.Text = ("-")
        lblGT.Text = ("-")
        lblVAT.Text = ("-")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub
End Class
