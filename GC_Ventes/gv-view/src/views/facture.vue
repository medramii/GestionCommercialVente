<template>
  <div>
    <h2 class="content-block">Facturation</h2>
    <DxDataGrid
      class="content-block"
      :focused-row-enabled="true"
      :column-auto-width="true"
      :column-hiding-enabled="true"
      id="grid-container"
      :ref="gridRefName"
      :selection="{ mode: 'single' }"
      :show-borders="false"
      :data-source="dataSource"
      @selection-changed="selectedChanged"
    >
      <DxFilterRow :visible="true" />
      <DxPaging 
        :page-size="10"
      />
      <DxPager 
        :show-page-size-selector="true" 
        :show-info="true" 
      />
      <DxEditing
        refresh-mode="repaint"
      />
      <DxColumn
        :width="100"
        data-field="numFac"
        caption="Numero"
      />
      <DxColumn
        data-field="client.raisonSociale"
        caption="Client"
      />
      <DxColumn
        data-field="dateFac"
        data-type="date"
        caption="Date de facture"
      />
      <DxColumn
        data-field="dateEcheance"
        data-type="date"
        caption="Date d'echeance"
      />
      <DxColumn
        data-field="modeReg.designation"
        caption="Mode Reglement"
      />
      <DxColumn
        data-field="montantDh"
        caption="Prix total (Dhs)"
      />
      <DxColumn
        :width="500"
        data-field="devise.designation"
        caption="Devise"
      />
      <DxColumn
        data-field="tauxDeChange"
        caption="Taux de change"
      />
      <DxColumn
        data-field="montantDevise"
        caption="Prix Devise"
      />
      <DxColumn
        data-field="observation"
        caption="Observation"
      />
      <DxMasterDetail
        :enabled="true"
        template="masterDetailTemplate"
      />
      <template #masterDetailTemplate="{ data: facture }">
        <DetailTemplate
          :FactureData="facture"
        />
      </template>
    </DxDataGrid>
    <DxSpeedDialAction
      :index="1"
      :on-click="exportGrid"
      icon="exportpdf"
      label="Exporter PDF"
    />
    <DxSpeedDialAction
      :index="2"
      :on-click="addFacture"
      icon="add"
      label="Ajouter"
    />
    <DxSpeedDialAction
      :visible="selectedRowIndex !== -1"
      :on-click="deleteFacture"
      :index="3"
      icon="trash"
      label="Supprimer"
    />
    <DxSpeedDialAction
      :visible="selectedRowIndex !== -1"
      :on-click="editFacture"
      :index="4"
      icon="edit"
      label="Modifier"
    />
  </div>
</template>
<script>
import {
  DxDataGrid,
  DxFilterRow,
  DxPager,
  DxPaging,
  DxEditing,
  DxColumn,
  DxMasterDetail,
} from 'devextreme-vue/data-grid';
import CustomStore from 'devextreme/data/custom_store';
import DxSpeedDialAction from 'devextreme-vue/speed-dial-action';
import {mapGetters, mapActions} from "vuex"

import DetailTemplate from '../components/facture/master-template.vue';

import { jsPDF } from 'jspdf';
import 'jspdf-autotable';
import { exportDataGrid as exportDataGridToPdf } from 'devextreme/pdf_exporter';

export default {
  data() {
    return {
      gridRefName: 'grid',
      dataSource: new CustomStore({
        key: 'id',
        load: async () => {
          await this.initFactures();
          return this.getFactures();
        },
        remove: () => {
          this.onDeleteFacture();
        }
      }),
      selectedFacId: null,
      selectedRowIndex: -1
    };
  },
  computed: {
    grid: function() {
      return this.$refs[this.gridRefName].instance;
    }
  },
  methods: {
    ...mapGetters(
      {
        getFactures: "facture/getFactures",
      },
    ),
    ...mapActions(
      {
        initFactures: "facture/initFactures",
      }
    ),
    selectedChanged(e) {
      this.selectedFacId = e.selectedRowKeys[0];
      this.selectedRowIndex = e.component.getRowIndexByKey(e.selectedRowKeys[0]);
    },
    addFacture: function() {
      this.$router.push({name: 'gestion-facture', params: {action: "Ajouter", id: "nouveau"}})
    },
    editFacture: function() {
      this.$router.push({name: 'gestion-facture', params: {action: "Modifier", id: this.selectedFacId}})
    },
    deleteFacture: async function() {
      this.grid.deleteRow(this.selectedRowIndex);
    },
    onDeleteFacture: function() {
      this.$store.dispatch('facture/deleteFacture', this.selectedFacId);
    },
    exportGrid() {
      const doc = new jsPDF();
      exportDataGridToPdf({
        jsPDFDocument: doc,
        component: this.grid
      }).then(() => {
        doc.save('Factures.pdf');
      });
    }
  },
  components: {
    DxDataGrid,
    DxFilterRow,
    DxPager,
    DxPaging,
    DxEditing,
    DxColumn,
    DxMasterDetail,
    DxSpeedDialAction,
    DetailTemplate
  },
};
</script>
<style>
#grid-container {
    height: 440px;
}
</style>
