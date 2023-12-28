UPDATE items
SET items_price_total = items_unit / 12,
items_taxe_value = items_unit / 12 *.2
WHERE items.items_projet_INDEX = 4
AND items.items_INDEX != 153

