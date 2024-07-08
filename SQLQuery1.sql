CREATE TABLE Admins (
    id INT PRIMARY KEY IDENTITY(1,1),
    admin NVARCHAR(15) NOT NULL,
    sifre NVARCHAR(15) NOT NULL
);
CREATE TABLE Users (
    id INT PRIMARY KEY IDENTITY(1,1),
    usern NVARCHAR(15) NOT NULL,
    sifre NVARCHAR(15) NOT NULL
);

CREATE TABLE Kullanicilar (
    id INT PRIMARY KEY IDENTITY(1,1),
    isim NVARCHAR(15) NOT NULL,
    soyisim NVARCHAR(15) NOT NULL,
    tc NVARCHAR(11) NOT NULL,
    dg DATE NOT NULL
);

CREATE TABLE Evler (
    id INT PRIMARY KEY IDENTITY(1,1),
    adres NVARCHAR(50) NOT NULL,
    metrekare NVARCHAR(4) NOT NULL,
    fiyat NVARCHAR(15) NOT NULL,
    kullanicilarid INT,
    FOREIGN KEY (kullanicilarid) REFERENCES Kullanicilar(id)
);