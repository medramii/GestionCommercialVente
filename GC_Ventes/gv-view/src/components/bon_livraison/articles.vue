<template>
  <div>
    <div class="master-detail-caption">{{ articles.key }}</div>
    <DxDataGrid
      :data-source="dataSource"
      :show-borders="true"
    >
      <DxColumn
        data-field="codeArticle"
        caption="Code Article"
      />
      <DxColumn
        data-field="codeMagasin"
        caption="Magasin"
      />
      <DxColumn
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
  </div>
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
  data() {
    return {
      
    };
  },
  methods: {
  }
};
</script>
<style>
.master-detail-caption {
    padding: 0 0 5px 10px;
    font-size: 14px;
    font-weight: bold;
}
</style>
