liczba_ocen = int(input("Podaj ilość ocen: "))

oceny = []

for i in range(liczba_ocen):
    ocena = float(input(f"Podaj ocenę {i + 1} (w skali od 1-6): "))
    oceny.append(ocena)

    suma_ocen = sum(oceny)
    srednia = suma_ocen / liczba_ocen

    print(f"Średnia : {srednia:.2f}")

    if srednia >= 3.0:
        print("Uczeń zdał.")
    else:
        print("Uczeń nie zdał.")