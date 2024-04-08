<template>
  <Header />
  <IndexHtml />
  <Footer />
</template>

<script>
import Header from "@/components/Header.vue";
import IndexHtml from "@/components/IndexHtml.vue";
import Footer from "@/components/Footer.vue";
export default {
  components: {
    Header,
    IndexHtml,
    Footer,
  },
};
</script>

<style lang="scss" scoped></style>
