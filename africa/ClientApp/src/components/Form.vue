<!-- eslint-disable vue/multi-word-component-names -->
<template>
    <form @submit.prevent="onSendApplication"
          id="myDropdown"
          class="form center">
        <h3 class="form__title">Application form</h3>
        <div>
            <label class="form__label">Name</label>
            <input v-model="applicationData.name"
                   class="form__input"
                   type="text"
                   name="name"
                   id="" />
        </div>
        <div>
            <label class="form__label">Phone</label>
            <input v-model="applicationData.phone"
                   class="form__input"
                   type="tel"
                   name="phone"
                   id="" />
        </div>
        <div>
            <label class="form__label">Email</label>
            <input v-model.trim="applicationData.email"
                   class="form__input"
                   type="email"
                   name=""
                   id="" />
        </div>
        <button type="submit" class="form__button">Send</button>
    </form>
</template>

<script>
    import axios from 'axios';
    import { email, required, helpers } from '@vuelidate/validators';
    //import useVuelidate from '@vuelidate/core';

    const number = helpers.regex(
        "serial",
        /^[0-9]{3}-[0-9]{3}-[0-9]{4}$/
    );

    export default {
        data() {
            return {
                applicationData: {
                    name: '',
                    phone: '',
                    email: '',
                }
            };
        },
        //validations() {
        //    return {
        //        applicationData: {
        //            name: { required },
        //            email: { required, email },
        //            phone: { required, number },
        //        }
        //    };
        //},
        setup() {
            return { v$: useVuelidate() };
        },
        methods: {
            onSendApplication() {
                return axios.post('api/Applications', {
                    name: this.applicationData.name,
                    email: this.applicationData.email,
                    phone: this.applicationData.phone,
                });
            }
        }
    };
</script>

