konwerter = input("Wybier skalę (C F): ")
temperatura = float(input("Podaj temperature: "))

if konwerter == "C":
    result = float(temperatura * 1.8 + 32)
    print(f"{temperatura}C = {result}F")
elif konwerter == "F":
    result = float((temperatura - 32) / 1.8)
    print(f"{temperatura}F = {result}C")
else:
    print("Błąd! Wybierz skalę C lub F.")