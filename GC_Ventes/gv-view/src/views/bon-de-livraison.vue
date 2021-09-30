<template>
  <div>
    <h2 class="content-block">Bon de livraison</h2>
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
        data-field="numBl"
        caption="Numero"
      />
      <DxColumn
        data-field="client.raisonSociale"
        caption="Client"
      />
      <DxColumn
        data-field="destination"
        caption="Destination"
      />
      <DxColumn
        data-field="dateBl"
        data-type="date"
        caption="Date"
      />
      <DxColumn
        :width="170"
        data-field="montantDh"
        caption="Montant total (Dhs)"
      />
      <DxColumn
        :width="500"
        data-field="typeVente"
        caption="Type de vente"
      />
      <DxColumn
        :width="500"
        data-field="devise"
        caption="Devise"
      />
      <DxColumn
        :width="500"
        data-field="tauxDeChange"
        caption="Taux de change"
      />
      <DxColumn
        :width="500"
        data-field="observation"
        caption="Observation"
      />
      <DxMasterDetail
        :enabled="true"
        template="masterDetailTemplate"
      />
      <template #masterDetailTemplate="{ data: bl }">
        <DetailTemplate
          :BlData="bl"
        />
      </template>
    </DxDataGrid>
    <DxSpeedDialAction
      :index="1"
      :on-click="exportGrid"
      icon="exportpdf"
      label="Imprimer la list"
    />
    <DxSpeedDialAction
      v-if="getSignedUser.idGroupe != 4"
      :index="2"
      :on-click="addBL"
      icon="add"
      label="Ajouter"
    />
    <DxSpeedDialAction
      v-if="getSignedUser.idGroupe != 4"
      :visible="selectedRowIndex !== -1"
      :on-click="deleteBL"
      :index="3"
      icon="trash"
      label="Supprimer"
    />
    <DxSpeedDialAction
      v-if="getSignedUser.idGroupe != 4"
      :visible="selectedRowIndex !== -1"
      :on-click="editBL"
      :index="4"
      icon="edit"
      label="Modifier"
    />
    <DxSpeedDialAction
      :visible="selectedRowIndex !== -1"
      :on-click="printBL"
      :index="5"
      icon="print"
      label="Imprimer le bon de livraison"
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
import notify from "devextreme/ui/notify";
import {mapGetters, mapActions} from "vuex"

import DetailTemplate from '../components/bon_livraison/master-template.vue';


import { jsPDF } from 'jspdf';
import 'jspdf-autotable';
import { exportDataGrid as exportDataGridToPdf } from 'devextreme/pdf_exporter';

export default {
  data() {
    return {
      gridRefName: 'grid',
      dataSource: new CustomStore({
        key: 'id',
        // load: this.initBLs(),
        load: async () => {
          await this.initBLs();
          return this.getBLs();
        },
        remove: () => {
          this.onDeleteBL();
        }
      }),
      selectedBlId: null,
      selectedRowIndex: -1
    };
  },
  computed: {
    grid: function() {
      return this.$refs[this.gridRefName].instance;
    },
    ...mapGetters({
      getSignedUser: "login/getSignedUser",
    }),
  },
  methods: {
    ...mapGetters(
      {
        getBLs: "bonLivraison/getBLs",
      },
    ),
    ...mapActions(
      {
        initBLs: "bonLivraison/initBLs",
        getBLById: "bonLivraison/getBLById",
      }
    ),
    selectedChanged(e) {
      this.selectedBlId = e.selectedRowKeys[0];
      this.selectedRowIndex = e.component.getRowIndexByKey(e.selectedRowKeys[0]);
    },
    addBL: function() {
      this.$router.push({name: 'gestion-bon-livraison', params: {action: "Ajouter", id: "nouveau"}})
    },
    editBL: function() {
      this.$router.push({name: 'gestion-bon-livraison', params: {action: "Modifier", id: this.selectedBlId}})
    },
    deleteBL: async function() {
      this.grid.deleteRow(this.selectedRowIndex);
    },
    onDeleteBL: function() {
      this.$store.dispatch('bonLivraison/deleteBL', this.selectedBlId);
    },
    exportGrid() {
      const doc = new jsPDF();
      exportDataGridToPdf({
        jsPDFDocument: doc,
        component: this.grid
      }).then(() => {
        doc.save('Bon_de_livraison.pdf');
      });
    },
    printBL: async function() {
      let Bl = await this.getBLById(this.selectedBlId);
      Bl = Bl.data;
      console.log(Bl);

      let articles = Bl._0110LigneBonLivraisons;
      
      articles.forEach(art => {
        art["article"] = art.codeArticleNavigation.designation;
      });

      console.log(articles);




      /* -------------------------------------------------------- */

      if (!Bl) {
        notify("Aucun données a exporter", "error", 2000);
        return;
      }
    /* ------------------------------------------------------- */
      var pdf = new jsPDF("p", "pt");

      var pageContent = function () {

        // Numero de Bon de Livraison
        // pdf.setFont("Calibri");
        pdf.setFillColor(115, 212, 127);
        pdf.rect(0, 30, 150, 30, "F");
        pdf.rect(pdf.internal.pageSize.width - 30, 30, 30, 30, "F");
        pdf.setFontSize(14);
        pdf.setTextColor(255, 255, 255);
        pdf.text(20, 50, "N° " + Bl.numBl);

        // Titre
        // pdf.setFont("Calibri");
        pdf.setTextColor(115, 212, 127);
        pdf.setFontSize(22);
        pdf.text("Bon de Livraison", pdf.internal.pageSize.width - 50, 55, {
          align: "right",
        });

        // Bon de Livraison info
        // pdf.setFont("Calibri");
        pdf.setTextColor(0, 0, 0);
        pdf.setFontSize(12);
        pdf.text(40, 150, "Numero de bon de livraison : " + Bl.numBl);
        pdf.text(40, 170, "Date : " + 
          new Date(
            Bl.dateBl
          ).toLocaleDateString("fr-CA", {
            year: "numeric",
            month: "2-digit",
            day: "2-digit",
          })
        );
      
        pdf.text(
          pdf.internal.pageSize.width - 40, 150,
          "Client : " + Bl.codeClientNavigation.raisonSociale, 
          {align: "right"}
        );
        pdf.text(
          "Livré à : " + Bl.idDestinationNavigation.ville, 
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

        pdf.setFillColor(250, 250, 250);
        pdf.rect(100, 250, pdf.internal.pageSize.width - 200, 95, "F");

        // pdf.setFillColor(255, 255, 255);
        // pdf.rect(100, 375, (pdf.internal.pageSize.width - 200)/2, 30, "F");
        pdf.setFillColor(115, 212, 127);
        pdf.rect(
          (pdf.internal.pageSize.width - 200)/2 + 100, 315,
          (pdf.internal.pageSize.width - 200)/2, 30, "F"
        );

        pdf.setFontSize(14);
        pdf.setTextColor(0);
        pdf.text(115, 270, "Devise");
        pdf.text(115, 300, "Taux de change");
        pdf.text(115, 330, "Montant");

        pdf.text(pdf.internal.pageSize.width - 115, 270, Bl.devise, {align: "right"});
        pdf.text(pdf.internal.pageSize.width - 115, 300, Bl.tauxDeChange.toString(), {align: "right"});
        pdf.setFontSize(16);
        pdf.setTextColor(255, 255, 255);
        pdf.text(pdf.internal.pageSize.width - 115, 335, Bl.montantDh.toString() + " Dhs", {align: "right"});
      
      };

      var columns = [
        { title: "Article", dataKey: "article" },
        { title: "Quantité", dataKey: "qte" },
        { title: "Prix unitaire (Dhs)", dataKey: "prix" },
        { title: "Montant (Dhs)", dataKey: "montant" },
      ];

      pdf.autoTable(columns, articles, {
        // theme: "grid",
        didDrawPage: pageContent,
        margin: {
          top: 390,
          left: 40,
          right: 40,
          bottom: 40,
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
          fillColor: [115, 212, 127]
        },
        bodyStyles: {
          fontSize: 11,
        },
      });

      pdf.save("Bon de Livraison N° " + Bl.numBl + ".pdf");
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
    /* height: auto;
    max-height: 440px; */
}
</style>
