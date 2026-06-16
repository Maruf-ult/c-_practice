using AutoMapper;
using HospitalManagement.Application.DTOs.AppointmentDtos;
using HospitalManagement.Application.DTOs.Common;
using HospitalManagement.Application.DTOs.DoctorDtos;
using HospitalManagement.Application.DTOs.PatientDtos;
using HospitalManagement.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreatePatientDto,Patient>();
            CreateMap<UpdatePatientDto, Patient>();
            CreateMap<Patient, PatientResponseDto>();
            CreateMap<Patient, PatientDetailsDto>();

            CreateMap<AddressDto, Address>()
                .ReverseMap();
            CreateMap<CreateDoctorDto, Doctor>();

            CreateMap<Doctor, DoctorSummaryDto>();

            CreateMap<CreateAppointmentDto, Appointment>();

            CreateMap<Appointment, AppointmentResponseDto>();
        }
    }
}
