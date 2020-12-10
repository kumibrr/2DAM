MILLE = 1.609344
GALLON = 3.785411784

def l100kmtompg(litresPer100Km):
    milles = litresPer100Km * MILLE * 100 / GALLON
    return milles

def mpgtol100km(milesPerGalon):
    return (milesPerGalon / GALLON) * MILLE