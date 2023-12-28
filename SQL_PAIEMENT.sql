SELECT
  items.`INDEX`,
  items.items_INDEX,
  items.items_projet_INDEX,
  items.items_code,
  items.items_name,
  paiement.Items_paye_qui,
  paiement.Items_Mt_payé,
  paiement.Items_ff
FROM items
  INNER JOIN paiement
    ON items.items_projet_INDEX = paiement.Project_Index
    AND items.items_INDEX = paiement.Items_Index