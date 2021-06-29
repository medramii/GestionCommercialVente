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
    <DxSpeedDialAction
      :visible="selectedRowIndex !== -1"
      :on-click="printFacture"
      :index="5"
      icon="print"
      label="Imprimer"
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
        getFactureById: "facture/getFactureById",
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
    },
    printFacture: async function() {
      let facture = await this.getFactureById(this.selectedFacId);
      facture = facture.data[0];
      // if (!!facture) {
      //   this.notify("Aucun donne a exporter", "error");
      //   return;
      // }
      console.log(facture);
    /* ------------------------------------------------------- */
      var pdf = new jsPDF("p", "pt");

      var pageContent = function (data) {

        // Numero de facture
        // pdf.setFont("Calibri");
        pdf.setFillColor(255, 121, 78);
        pdf.rect(0, 30, 150, 30, "F");
        pdf.rect(pdf.internal.pageSize.width - 30, 30, 30, 30, "F");
        pdf.setFontSize(14);
        pdf.setTextColor(255, 255, 255);
        pdf.text(20, 50, "Facture N° " + facture.numFac);

        // Logo du societe
        // pdf.setFont("Calibri");
        pdf.setTextColor(255, 121, 78);
        pdf.setFontSize(22);
        pdf.text("Gestion Commercial", pdf.internal.pageSize.width - 50, 55, {
          align: "right",
        });

        // Facture info
        // pdf.setFont("Calibri");
        pdf.setTextColor(0, 0, 0);
        pdf.setFontSize(12);
        pdf.text(40, 150, "Numero de facture : " + facture.numFac);
        pdf.text(40, 170, "Facturé le : " + 
          new Date(
            facture.dateFacture
          ).toLocaleDateString("fr-CA", {
            year: "numeric",
            month: "2-digit",
            day: "2-digit",
          })
        );
        pdf.text(40, 190, "Date d'écheance : " + 
          new Date(
            facture.dateEcheance
          ).toLocaleDateString("fr-CA", {
            year: "numeric",
            month: "2-digit",
            day: "2-digit",
          })
        );
      
        pdf.text(
          pdf.internal.pageSize.width - 40, 150,
          "Client : " + facture.nomClient, 
          {align: "right"}
        );
        pdf.text(
          "Envoyé à : " + facture.addressClient, 
          pdf.internal.pageSize.width - 40, 170, 
          {align: "right"}
        );

        // Footer
        pdf.setDrawColor(224, 224, 224);
        pdf.line(
          35,
          pdf.internal.pageSize.height - 30,
          pdf.internal.pageSize.width - 35,
          pdf.internal.pageSize.height - 30
        );
        pdf.setFontSize(10);
        pdf.setTextColor(66, 66, 66);
        pdf.text(
          "www.gestion-commercial.ma",
          40,
          pdf.internal.pageSize.height - 12
        );
        pdf.text(
          "Gestion Commercial",
          pdf.internal.pageSize.width - 40,
          pdf.internal.pageSize.height - 12,
          {align: "right"}
        );
      };


      pdf.setFillColor(250, 250, 250);
      pdf.rect(100, 250, pdf.internal.pageSize.width - 200, 155, "F");

      // pdf.setFillColor(255, 255, 255);
      // pdf.rect(100, 375, (pdf.internal.pageSize.width - 200)/2, 30, "F");
      pdf.setFillColor(255, 121, 78);
      pdf.rect(
        (pdf.internal.pageSize.width - 200)/2 + 100, 375,
        (pdf.internal.pageSize.width - 200)/2, 30, "F"
      );




      pdf.setFontSize(14);
      pdf.setTextColor(0);
      pdf.text(115, 270, "Mode de reglement");
      pdf.text(115, 300, "Devise");
      pdf.text(115, 330, "Taux de change");
      pdf.text(115, 360, "Montant devise");
      pdf.text(115, 390, "Montant Dh");

      pdf.text(pdf.internal.pageSize.width - 115, 270, facture.modeReglementDetails.designation, {align: "right"});
      pdf.text(pdf.internal.pageSize.width - 115, 300, facture.deviseDetails.designation, {align: "right"});
      pdf.text(pdf.internal.pageSize.width - 115, 330, facture.tauxDeChange.toString(), {align: "right"});
      pdf.text(pdf.internal.pageSize.width - 115, 360, facture.montantDevise.toString(), {align: "right"});
      pdf.setFontSize(16);
      pdf.setTextColor(255, 255, 255);
      pdf.text(pdf.internal.pageSize.width - 115, 395, facture.montantDh.toString() + " Dhs", {align: "right"});

      var columns = [
        { title: "Livraison", dataKey: "livraison" },
        { title: "Date", dataKey: "date" },
        { title: "Destination", dataKey: "destination" },
        { title: "Type de vente", dataKey: "typeDeVente" },
        { title: "Montant (Dhs)", dataKey: "montantDh" },
      ];

      pdf.autoTable(columns, facture.lignesFacture, {
        // theme: "grid",
        didDrawPage: pageContent,
        margin: {
          top: 450,
          left: 40,
          right: 40,
          bottom: 20,
        },
        styles: {
          cellPadding: 5,
          overflow: "linebreak",
          valign: "middle",
          halign: "center",
          lineColor: [0, 0, 0],
          lineWidth: 0.05,
        },
        headStyles: {
          fontSize: 13,
          fillColor: [255, 121, 78]
        },
        bodyStyles: {
          fontSize: 11,
        },
      });

      pdf.save("Facture N° " + facture.numFac + ".pdf");
    },
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
