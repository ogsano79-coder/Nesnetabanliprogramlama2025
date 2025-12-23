SELECT b.bolum_adi, d.ad, d.soyad
FROM Doktor d
JOIN Bolum b ON d.bolum_id = b.bolum_id;