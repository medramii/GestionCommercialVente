<template>
  <div>
    <div class="dx-fieldset">
      <div class="dx-field">
        <div class="dx-field-label" style="font-size: 16px">Date début</div>
        <div class="dx-field-value">
          <DxDateBox
            v-model="date.start"
            :max="new Date()"
            type="date"
            @value-changed="onDateChange"
          />
        </div>
        <div class="dx-field-label"></div>
        <div class="dx-field-label" style="font-size: 16px">Date fin</div>
        <div class="dx-field-value">
          <DxDateBox
            v-model="date.end"
            :max="new Date()"
            type="date"
            @value-changed="onDateChange"
          />
        </div>
      </div>
    </div>

    <DxResponsiveBox :screen-by-width="screen" single-column-screen="sm">
      <DxRow :ratio="1" />
      <DxRow :ratio="1" />
      <DxRow :ratio="3" screen="sm" />

      <DxCol :ratio="1" />
      <DxCol :ratio="1" />
      <DxCol :ratio="1" />
      <DxCol :ratio="1" />
      <DxCol :ratio="1" />

      <DxItem>
        <DxLocation :row="0" :col="0" :colspan="3" screen="lg" />
        <DxLocation :row="0" :col="0" :colspan="5" screen="sm" />
        <div>
          <DxChart
            class="dx-card responsive-paddings"
            id="chart"
            :data-source="this.getTopClients"
            palette="Green Mist"
            :sticky-hovering="true"
          >
            <DxSeries
              argument-field="client"
              value-field="count"
              name="Livraisons"
              type="bar"
            />
            <DxArgumentAxis>
              <DxLabel
                overlapping-behavior="stagger"
                word-wrap="none"
              />
            </DxArgumentAxis>
            <DxMargin :bottom="20" />
            <DxLegend
              vertical-alignment="bottom"
              horizontal-alignment="center"
              item-text-position="right"
            />
            <DxExport :enabled="true" />
            <DxTitle :text="'Top Clients ( '+ formatDate(date.start) + ' / ' + formatDate(date.end) + ' )'">
              <DxSubtitle text="livraisons par client" />
            </DxTitle>
            <DxTooltip :enabled="true" />
          </DxChart>
        </div>
      </DxItem>

      <DxItem>
        <DxLocation :row="0" :col="3" :colspan="2" screen="lg" />
        <DxLocation :row="1" :col="0" :colspan="5" screen="sm" />
        <div>
          <DxPieChart
            class="dx-card responsive-paddings"
            id="pie"
            :data-source="this.getLivraisons"
            palette="Harmony Light"
            :title="'Facturation de bon de livraison ( '+ formatDate(date.start) + ' / ' + formatDate(date.end) + ' )'"
          >
            <DxSeries argument-field="facture" value-field="count">
              <DxLabel
                :visible="true"
                :customize-text="formatLabel"
                position="columns"
              >
                <DxConnector :visible="true" :width="0.5" />
                <DxFont :size="16" />
              </DxLabel>
            </DxSeries>
            <DxLegend
              :column-count="4"
              orientation="horizontal"
              item-text-position="right"
              horizontal-alignment="center"
              vertical-alignment="bottom"
            />
            <DxExport :enabled="true" />
          </DxPieChart>
        </div>
      </DxItem>

      <DxItem>
        <DxLocation :row="1" :col="0" :colspan="5" screen="lg" />
        <DxLocation :row="2" :col="0" :colspan="5" screen="sm" />
                <div>
          <DxChart
            class="dx-card responsive-paddings"
            id="chart"
            :data-source="this.getTopDestinations"
            palette="Carmine"
            :sticky-hovering="true"
          >
            <DxSeries
              argument-field="destination"
              value-field="count"
              name="Livraisons"
              type="bar"
            />
            <DxArgumentAxis>
              <DxLabel
                overlapping-behavior="stagger"
                word-wrap="none"
              />
            </DxArgumentAxis>
            <DxMargin :bottom="20" />
            <DxLegend
              vertical-alignment="bottom"
              horizontal-alignment="center"
              item-text-position="right"
            />
            <DxExport :enabled="true" />
            <DxTitle :text="'Top Destinations ( '+ formatDate(date.start) + ' / ' + formatDate(date.end) + ' )'">
              <DxSubtitle text="livraisons par destination" />
            </DxTitle>
            <DxTooltip :enabled="true" />
          </DxChart>
        </div>
      </DxItem>
    </DxResponsiveBox>

  </div>
</template>
<script>
import {
  DxResponsiveBox,
  DxItem,
  DxLocation,
  DxCol,
  DxRow,
} from "devextreme-vue/responsive-box";
import DxDateBox from 'devextreme-vue/date-box';
import { mapActions, mapGetters } from "vuex";
import {
  DxChart,
  DxSeries,
  DxArgumentAxis,
  // DxCommonSeriesSettings,
  DxExport,
  // DxGrid,
  DxMargin,
  DxLegend,
  DxTitle,
  DxSubtitle,
  DxTooltip,
} from "devextreme-vue/chart";
import DxPieChart, {
  DxLabel,
  DxConnector,
  DxFont,
} from "devextreme-vue/pie-chart";

export default {
  components: {
    DxResponsiveBox,
    DxItem,
    DxLocation,
    DxCol,
    DxRow,
    DxDateBox,
    DxChart,
    DxSeries,
    DxArgumentAxis,
    // DxCommonSeriesSettings,
    DxExport,
    // DxGrid,
    DxMargin,
    DxLegend,
    DxTitle,
    DxSubtitle,
    DxTooltip,
    DxPieChart,
    DxLabel,
    DxConnector,
    DxFont,
  },

  data() {
    return {
      screen(width) {
        return width < 1000 ? "sm" : "lg";
      },
      date: {
        "start": new Date(),
        "end": new Date()
      },
    };
  },
  computed: {
    ...mapGetters({
      getLivraisons: "dashboard/getLivraisons",
      getTopDestinations: "dashboard/getTopDestinations",
      getTopClients: "dashboard/getTopClients",
    }),
  },
  methods: {
    ...mapActions({
      initLivraisons: "dashboard/initLivraisons",
      initTopDestinations: "dashboard/initTopDestinations",
      initTopClients: "dashboard/initTopClients",
    }),
    formatDate: (date) => {
      return new Date(
          date
        ).toLocaleDateString("fr-CA", {
          year: "numeric",
          month: "2-digit",
          day: "2-digit",
        })
    },
    onDateChange: function () {
      let start = this.formatDate(this.date.start);
      let end = this.formatDate(this.date.end);

      this.initLivraisons({start, end});
      this.initTopDestinations({start, end});
      this.initTopClients({start, end});
    },
    formatLabel(pointInfo) {
      return `${pointInfo.valueText} (${pointInfo.percentText})`;
    },
  },
  beforeMount() {
    this.date.start.setMonth(this.date.start.getMonth() - 1);
    console.log(this.date.start);
    let start = this.formatDate(this.date.start);
    let end = this.formatDate(this.date.end);

    this.initLivraisons({start, end});
    this.initTopDestinations({start, end});
    this.initTopClients({start, end});
  },
};
</script>
<style>
.options {
  padding: 20px;
  background-color: rgba(191, 191, 191, 0.15);
  margin-top: 20px;
}

.option {
  margin-top: 10px;
}

.caption {
  font-size: 18px;
  font-weight: 500;
}

.option > span {
  margin-right: 14px;
}

.option > .dx-widget {
  display: inline-block;
  vertical-align: middle;
}
</style>
