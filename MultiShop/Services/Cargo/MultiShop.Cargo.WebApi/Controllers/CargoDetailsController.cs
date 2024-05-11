﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoDetailDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _cargoDetailService;

        public CargoDetailsController(ICargoDetailService CargoDetailService)
        {
            _cargoDetailService = CargoDetailService;
        }

        // GET
        [HttpGet]
        public IActionResult CargoDetailList()
        {
            var values = _cargoDetailService.TGetAll();

            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoDetailById(int id)
        {
            var value = _cargoDetailService.TGetById(id);

            return Ok(value);
        }

        // POST
        [HttpPost]
        public IActionResult CreateCargoDetail(CreateCargoDetailDto createCargoDetailDto)
        {
            CargoDetail cargoDetail = new CargoDetail()
            {
                SenderCustomer = createCargoDetailDto.SenderCustomer,
                ReceiverCustomer = createCargoDetailDto.ReceiverCustomer,
                Barcode = createCargoDetailDto.Barcode,
                CargoCompanyId = createCargoDetailDto.CargoCompanyId
            };

            _cargoDetailService.TInsert(cargoDetail);

            return Ok("Kargo Detayları başarıyla oluşturuldu!");
        }

        // PUT
        [HttpPut]
        public IActionResult UpdateCargoDetail(UpdateCargoDetailDto updateCargoDetailDto)
        {
            CargoDetail cargoDetail = new CargoDetail()
            {
                CargoDetailId = updateCargoDetailDto.CargoDetailId,
                SenderCustomer = updateCargoDetailDto.SenderCustomer,
                ReceiverCustomer = updateCargoDetailDto.ReceiverCustomer,
                Barcode = updateCargoDetailDto.Barcode,
                CargoCompanyId = updateCargoDetailDto.CargoCompanyId
            };

            _cargoDetailService.TUpdate(cargoDetail);

            return Ok("Kargo Detayları başarıyla güncellendi!");
        }

        // DELETE
        [HttpDelete]
        public IActionResult RemoveCargoDetail(int id)
        {
            _cargoDetailService.TDelete(id);

            return Ok("Kargo Detayları başarıyla silindi!");
        }

    }
}
