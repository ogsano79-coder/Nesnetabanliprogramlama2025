SELECT h.ad, h.soyad, r.randevu_tarihi, d.ad AS doktor_ad, d.soyad AS doktor_soyad
FROM Randevu r
JOIN Hasta h ON r.hasta_id = h.hasta_id
JOIN Doktor d ON r.doktor_id = d.doktor_id
WHERE h.hasta_id = 1;