liczba1 = float(input("Podaj pierwszą liczbę: "))
operator = input("Wybierz operator (+ - * /): ")
liczba2 = float(input("Podaj drugą liczbę: "))

if operator == "+":
    result = liczba1 + liczba2
    print(f"Wynik: {result}")
elif operator == "-":
    result = liczba1 - liczba2
    print(f"Wynik: {result}")
elif operator == "*":
    result = liczba1 * liczba2
    print(f"Wynik: {result}")
elif operator == "/":
    result = liczba1 / liczba2
    print(f"Wynik: {result}")
else:
    print("Błąd! Wybierz jeden z dostępnych operatorów.")