<template>
  <DxDataGrid
    :data-source="articles"
    :show-borders="true"
    :column-auto-width="true"
    :column-hiding-enabled="true"
  >
    <DxColumn
      :width="100"
      data-field="codeArticle"
      caption="Numero"
    />
    <DxColumn
      data-field="article.designation"
      caption="Article"
    />
    <DxColumn
      data-field="magasin.designation"
      caption="Magasin"
    />
    <DxColumn
      :width="100"
      data-field="qte"
      caption="Quantité"
    />
    <DxColumn
      data-field="prix"
      caption="Prix unitaire (Dhs)"
    />
    <DxColumn
      data-field="montant"
      caption="Prix total (Dhs)"
    />
  </DxDataGrid>
</template>
<script>
import { DxDataGrid, DxColumn } from 'devextreme-vue/data-grid';

export default {
  components: { DxDataGrid, DxColumn },
  props: {
    articles: {
      type: Object,
      default: ()=>{}
    }
  },
};
</script>
<style>
.master-detail-caption {
    padding: 0;
    font-size: 14px;
    font-weight: bold;
}
</style>
